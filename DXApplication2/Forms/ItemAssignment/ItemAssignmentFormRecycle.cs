using DevExpress.XtraEditors;
using DXApplication2.DataAccess;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication2.Services;

namespace DXApplication2.Forms.ItemAssignment
{
    public partial class ItemAssignmentFormRecycle : XtraForm
    {
        private UnitOfWork _unitOfWork;

        public ItemAssignmentFormRecycle()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private async void ItemAssignmentFormRecycle_Load(object sender, EventArgs e)
        {
            await LoadItemAssignmentData();
        }

        private async Task LoadItemAssignmentData()
        {
            try
            {
                _unitOfWork = new UnitOfWork();
                var itemAssignments = (await _unitOfWork.ItemsAssignmentRepository.GetAllAsync()).Where(item =>
                    item.IsDeleted);
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
                gridControl1.DataSource = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"exception {ex.Message}");
            }
        }

        private async void repositoryItemButtonEdit1_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var itemAssignmentUlid = gridView1.GetFocusedRowCellValue("Ulid")?.ToString();
                if (string.IsNullOrWhiteSpace(itemAssignmentUlid))
                {
                    XtraMessageBox.Show("الرجاء تحديد تعيين عنصر صالح للحذف.", "تحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var itemAssignment = await _unitOfWork.ItemsAssignmentRepository.GetByIdAsync(itemAssignmentUlid);
                if (itemAssignment == null)
                {
                    XtraMessageBox.Show(" العنصر غير موجود.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (e.Button.Tag.ToString())
                {
                    case "btn_return":
                    {
                        if (XtraMessageBox.Show("هل تريد الاستعادة فعلا؟", "", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            itemAssignment.IsDeleted = false;
                            await _unitOfWork.ItemsAssignmentRepository.UpdateAsync(itemAssignmentUlid, itemAssignment);
                            PublicMessages.Message(MessageType.Restore);
                        }

                        break;
                    }
                }

                await LoadItemAssignmentData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
        }

        private async void repositoryItemButtonEdit2_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var itemAssignmentUlid = gridView1.GetFocusedRowCellValue("Ulid")?.ToString();
                if (string.IsNullOrWhiteSpace(itemAssignmentUlid))
                {
                    XtraMessageBox.Show("الرجاء تحديد تعيين عنصر صالح للحذف.", "تحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var itemAssignment = await _unitOfWork.ItemsAssignmentRepository.GetByIdAsync(itemAssignmentUlid);
                if (itemAssignment == null)
                {
                    XtraMessageBox.Show(" العنصر غير موجود.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (e.Button.Tag.ToString())
                {
                    case "btn_delete":
                    {
                        if (XtraMessageBox.Show("هل تريد حذف نهائياً فعلا؟", "", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            await _unitOfWork.ItemsAssignmentRepository.DeleteAsync(itemAssignmentUlid);
                            PublicMessages.Message(MessageType.Delete);
                        }

                        break;
                    }
                }

                await LoadItemAssignmentData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
        }

        private async void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await LoadItemAssignmentData();
        }

        private async void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("هل تريد حذف جميع المواد المحذوفة؟", "تأكيد",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                var itemAssignments = (await _unitOfWork.ItemsAssignmentRepository.GetAllAsync())
                    .Where(item => item.IsDeleted).ToList();
                if (itemAssignments.Count == 0)
                {
                    XtraMessageBox.Show("لا توجد تعيينات محذوفة.", "تنبيه", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    foreach (var itemAssignment in itemAssignments)
                    {
                        await _unitOfWork.ItemsAssignmentRepository.DeleteAsync(itemAssignment.Ulid);
                    }
                }

                PublicMessages.Message(MessageType.Delete, "تم حذف جميع التعيينات المحذوفة بنجاح.");
                await LoadItemAssignmentData();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
               
            }
            finally
            {
                _unitOfWork = new UnitOfWork();
            }
        }
    }
}