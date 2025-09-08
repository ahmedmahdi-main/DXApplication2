using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication2.DataAccess;
using DXApplication2.Services;

namespace DXApplication2.Forms.Employees
{
    public partial class EmployeesFrom : XtraForm
    {
        private readonly UnitOfWork _unitOfWork;

        public EmployeesFrom()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private async void EmployeesFrom_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadEmployeesData();
            }
            catch (Exception ex)
            {
                PublicMessages.Message(
                     MessageType.Error,
                     "حدث خطأ أثناء تحميل بيانات الموظفين: " + ex.Message);
            }
        }

        private async Task LoadEmployeesData()
        {
            try
            {
                

                var employees = await _unitOfWork.EmployeesRepository.GetAllAsync();
                gridControl1.DataSource = employees.ToList();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(
                    "حدث خطأ أثناء تحميل البيانات: " + exception.Message,
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var frm = new EmployeesOperationsForm();
                frm.ShowDialog();
                await LoadEmployeesData();
            }
            catch (Exception ex)
            {
                PublicMessages.Message(
                    MessageType.Error,
                    "حدث خطأ أثناء إضافة الموظف: " + ex.Message);
            }
        }

        private async void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var employeeId = (Convert.ToString(gridView1.GetFocusedRowCellValue("Ulid")));

                var officialLetter = await _unitOfWork.EmployeesRepository.GetByIdAsync(employeeId);

                if (officialLetter == null) return;
                switch (e.Button.Tag.ToString())
                {
                    case "btn_edit":
                    {
                        var frm = new EmployeesOperationsForm { EmployeeId = employeeId };
                        frm.ShowDialog();
                        break;
                    }
                    case "btn_delete":
                    {
                        if (XtraMessageBox.Show("هل تريد الحذف ؟", "", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            await _unitOfWork.EmployeesRepository.DeleteAsync(employeeId);
                            PublicMessages.Message(MessageType.Delete);
                        }

                        break;
                    }
                }

                await LoadEmployeesData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(@$"Exception {ex.Message}");
            }
        }
    }
}