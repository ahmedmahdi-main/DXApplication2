using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DXApplication2.DataAccess;
using DXApplication2.Services;
using MoreLinq.Extensions;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication2.Forms.ItemAssignment
{
    public partial class ItemAssignmentForm : XtraForm
    {
        private  UnitOfWork _unitOfWork;
        private DataTable _itemAssignmentDataTable;
        public ItemAssignmentForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _itemAssignmentDataTable = new DataTable();
        }

        private async void ItemAssignmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadItemAssignmentData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"exception {ex.Message}");
            }

        }

        private async Task LoadItemAssignmentData()
        {
            try
            {
                _unitOfWork = new UnitOfWork();
                var itemAssignments = (await _unitOfWork.ItemsAssignmentRepository.GetAllAsync()).Where(item =>
                    !item.IsDeleted);
                var employees = await _unitOfWork.EmployeesRepository.GetAllAsync();
                var items = await _unitOfWork.ItemsRepository.GetAllAsync();

                if (!string.IsNullOrWhiteSpace(employeeNameTextEdit.Text))
                {
                    employees = employees
                        .Where(e => e.Name.Contains(employeeNameTextEdit.Text, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }
                if (!string.IsNullOrWhiteSpace(itemsNameTextEdit.Text))
                {
                    items = items
                        .Where(i => i.Name.Contains(itemsNameTextEdit.Text, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }
                var data = itemAssignments
                    .Join(employees, assignment => assignment.EmployeeId, employee => employee.Ulid,
                        (assignment, employee) => new { assignment, employee })
                    .Join(items, @t => @t.assignment.ItemId, item => item.Ulid,
                        (@t, item) => new
                        {
                            @t.assignment.Id,
                            @t.assignment.Ulid,
                            @t.assignment.Price,
                            EmployeeName = @t.employee.Name,
                            ItemName = item.Name,
                            @t.assignment.ItemId,
                            @t.assignment.EmployeeId,
                            @t.assignment.AssignmentNumber,
                            @t.assignment.ConditionOnReturn,
                            @t.assignment.Notes,
                            @t.assignment.AssignmentDate,
                            @t.assignment.ReturnDate,
                            @t.assignment.Count
                        });
                gridControl1.DataSource = data.Any()
                    ? data.OrderBy(d => d.EmployeeName).ToList()
                    :
                    // Handle case where no item assignments exist
                    null;
                _itemAssignmentDataTable = data.ToDataTable();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred while loading item assignments: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new ItemAssignmentOperationsForm();
            frm.ShowDialog();

            await LoadItemAssignmentData();

        }

        private async void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var itemAssignmentUlid = gridView1.GetFocusedRowCellValue("Ulid")?.ToString();
            if (string.IsNullOrWhiteSpace(itemAssignmentUlid))
            {
                XtraMessageBox.Show("Please select a valid item assignment to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var itemAssignment = await _unitOfWork.ItemsAssignmentRepository.GetByIdAsync(itemAssignmentUlid);
            if (itemAssignment == null)
            {
                XtraMessageBox.Show("Item assignment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (e.Button.Tag.ToString())
            {
                case "btn_edit":
                    {
                        var frm = new ItemAssignmentOperationsForm { ItemAssignmentId = itemAssignmentUlid };
                        frm.ShowDialog();
                        break;
                    }
                case "btn_delete":
                    {
                        if (XtraMessageBox.Show("هل تريد الحذف ؟", "", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            itemAssignment.IsDeleted = true;
                            await _unitOfWork.ItemsAssignmentRepository.UpdateAsync(itemAssignmentUlid,itemAssignment);
                            PublicMessages.Message(MessageType.Delete);
                        }

                        break;
                    }
            }
            await LoadItemAssignmentData();

        }

        private async void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await LoadItemAssignmentData();
            employeeNameTextEdit.Text = string.Empty;
            itemsNameTextEdit.Text = string.Empty;
        }

        private async void employeeNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            await LoadItemAssignmentData();
        }

        private async void itemsNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            await LoadItemAssignmentData();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_itemAssignmentDataTable == null) return;
            var filePath = AppDomain.CurrentDomain.BaseDirectory + @"PrintFiles\Report1.repx";
            var report = XtraReport.FromFile(filePath);
            var formDataSet = new DataSet();
            formDataSet.Tables.Add(_itemAssignmentDataTable.Copy());
            formDataSet.Tables[0].TableName = "ItemAssignments";
            report.DataSource = formDataSet;
            report.ShowPreview();
            //try
            //{
            //    // Check if there's data to print
            //    if (gridControl1.DataSource == null || gridView1.RowCount == 0)
            //    {
            //        XtraMessageBox.Show("لا توجد بيانات للطباعة.", "تنبيه", 
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }

            //    // Store the original visibility state of gridColumn1
            //    bool originalVisibility = gridColumn1.Visible;

            //    try
            //    {
            //        // Hide the gridColumn1 (edit/delete buttons) for printing
            //        gridColumn1.Visible = false;

            //        // Show print preview dialog
            //        gridView1.ShowPrintPreview();
            //    }
            //    finally
            //    {
            //        // Restore the original visibility state
            //        gridColumn1.Visible = originalVisibility;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show($"حدث خطأ أثناء الطباعة: {ex.Message}", "خطأ",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}