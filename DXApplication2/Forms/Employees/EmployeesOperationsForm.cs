using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DXApplication2.DataAccess;
using DXApplication2.Entities;
using DXApplication2.Services;

namespace DXApplication2.Forms.Employees
{
    public partial class EmployeesOperationsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly UnitOfWork _unitOfWork;
        private Employee _employee;
        public string EmployeeId;
        public EmployeesOperationsForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private async Task LoadEmployeeData()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(EmployeeId))
                {
                    return;
                }

                try
                {
                    var employee = await _unitOfWork.EmployeesRepository.GetByIdAsync(EmployeeId);
                    if (employee == null) return;
                    NameTextEdit.Text = employee.Name;
                    DepartmentTextEdit.Text = employee.Department;
                    PositionTextEdit.Text = employee.Position;
                    NationalIDTextEdit.Text = employee.NationalId;
                    PhoneTextEdit.Text = employee.Phone;
                    EmailTextEdit.Text = employee.Email;
                }
                catch (Exception ex)
                {
                    PublicMessages.Message(MessageType.Error, $"حدث خطأ أثناء تحميل بيانات الموظف: {ex.Message}");
                }
            }
            catch (Exception exception)
            {
                PublicMessages.Message(MessageType.Error, $"حدث خطأ أثناء تحميل بيانات الموظف: {exception.Message}");
            }
        }

        private void ClearEmployeeData()
        {
            EmployeeId = string.Empty;
            NameTextEdit.Text = string.Empty;
            DepartmentTextEdit.Text = string.Empty;
            PositionTextEdit.Text = string.Empty;
            NationalIDTextEdit.Text = string.Empty;
            PhoneTextEdit.Text = string.Empty;
            EmailTextEdit.Text = string.Empty;
            IdTextEdit.Text = 0.ToString();
            _employee = null;
            NameTextEdit.Focus();

        }

        private void FullEmployeeData()
        {
            _employee ??= new Employee();
            _employee.Name = NameTextEdit.Text.Trim();
            _employee.Department = DepartmentTextEdit.Text.Trim();
            _employee.Position = PositionTextEdit.Text.Trim();
            _employee.NationalId = NationalIDTextEdit.Text.Trim();
            _employee.Phone = PhoneTextEdit.Text.Trim();
            _employee.Email = EmailTextEdit.Text.Trim();

        }
        private bool ValidateEmployeeData()
        {
            if (string.IsNullOrWhiteSpace(NameTextEdit.Text))
            {
                PublicMessages.Message(MessageType.Warning, "الرجاء إدخال اسم الموظف.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(DepartmentTextEdit.Text))
            {
                PublicMessages.Message(MessageType.Warning, "الرجاء إدخال قسم الموظف.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(NationalIDTextEdit.Text)) return true;
            PublicMessages.Message(MessageType.Warning, "الرجاء إدخال الرقم الوظيفي للموظف.");
            return false;
            // if (string.IsNullOrWhiteSpace(PhoneTextEdit.Text))
            // {
            //     PublicMessages.Message(MessageType.Warning, "الرجاء إدخال رقم هاتف الموظف.");
            //     return false;
            // }
            // if (string.IsNullOrWhiteSpace(EmailTextEdit.Text))
            // {
            //     PublicMessages.Message(MessageType.Warning, "الرجاء إدخال بريد إلكتروني للموظف.");
            //     return false;
            // }
            // if (string.IsNullOrWhiteSpace(PositionTextEdit.Text))
            // {
            //     PublicMessages.Message(MessageType.Warning, "الرجاء إدخال وظيفة الموظف.");
            //     return false;
            // }
        }
        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateEmployeeData())
                {
                    return;
                }
                FullEmployeeData();
                if (string.IsNullOrWhiteSpace(EmployeeId))
                {
                    await _unitOfWork.EmployeesRepository.AddAsync(_employee);
                   
                }
                else
                {
                    _employee.Ulid = EmployeeId;
                    await _unitOfWork.EmployeesRepository.BulkSaveAsync(new List<Employee> { _employee });
                   
                }
                PublicMessages.Message(MessageType.Save);
                ClearEmployeeData();
            }
            catch (Exception ex)
            {
                PublicMessages.Message(MessageType.Error, $"حدث خطأ أثناء حفظ بيانات الموظف: {ex.Message}");
            }
        }
        private async void EmployeesOperationsForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadEmployeeData();
            }
            catch (Exception ex)
            {
                PublicMessages.Message(MessageType.Error, $"حدث خطأ أثناء تحميل بيانات الموظف: {ex.Message}");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearEmployeeData();
        }
    }
}