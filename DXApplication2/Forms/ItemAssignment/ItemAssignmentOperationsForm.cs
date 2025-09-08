using DevExpress.XtraEditors;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication2.DataAccess;

namespace DXApplication2.Forms.ItemAssignment
{
    public partial class ItemAssignmentOperationsForm : XtraForm
    {
        private readonly UnitOfWork _unitOfWork;
        private Entities.ItemAssignment _itemAssignment;
        public string ItemAssignmentId;

        public ItemAssignmentOperationsForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private async void ItemAssignmentOperationsForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadLookupEdit();
                if (!string.IsNullOrWhiteSpace(ItemAssignmentId))
                {
                    LoadItemAssignmentData();
                }
                else
                {
                    _itemAssignment = new Entities.ItemAssignment();
                    AssignmentDateDateEdit.DateTime = DateTime.Now;
                    ReturnDateDateEdit.EditValue = null;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private async Task LoadLookupEdit()
        {
            try
            {
                var employees = await _unitOfWork.EmployeesRepository.GetAllAsync();
                var items = await _unitOfWork.ItemsRepository.GetAllAsync();

                EmployeeIdLookUpEdit.Properties.DataSource = employees;
                ItemIdLookUpEdit.Properties.DataSource = items;

                // ConditionOnReturnTextEdit.Properties.DataSource = GetValues(typeof(ItemStatus)).Cast<ItemCondition>()
                //     .Select(status => new { Id = status.ToString().Replace('_', ' ') }).ToList();
                ConditionOnReturnTextEdit.Properties.DisplayMember = "Id";
                ConditionOnReturnTextEdit.Properties.ValueMember = "Id";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private async void LoadItemAssignmentData()
        {
            try
            {
                _itemAssignment = await _unitOfWork.ItemsAssignmentRepository.GetByIdAsync(ItemAssignmentId);
                if (_itemAssignment == null) return;
                EmployeeIdLookUpEdit.EditValue = _itemAssignment.EmployeeId;
                ItemIdLookUpEdit.EditValue = _itemAssignment.ItemId;
                PriceTextEdit.Text = _itemAssignment.Price.ToString(CultureInfo.InvariantCulture);
                AssignmentNumberTextEdit.Text = _itemAssignment.AssignmentNumber;
                ConditionOnReturnTextEdit.EditValue = _itemAssignment.ConditionOnReturn;
                NotesTextEdit.Text = _itemAssignment.Notes;
                AssignmentDateDateEdit.EditValue = _itemAssignment.AssignmentDate;
                ReturnDateDateEdit.EditValue = _itemAssignment.ReturnDate;
                CountSpinEdit.EditValue = _itemAssignment.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void FullItemAssignmentData()
        {
            _itemAssignment ??= new Entities.ItemAssignment();
            _itemAssignment.EmployeeId = EmployeeIdLookUpEdit.EditValue.ToString() ?? string.Empty;
            _itemAssignment.ItemId = ItemIdLookUpEdit.EditValue.ToString() ?? string.Empty;
            _itemAssignment.AssignmentNumber = AssignmentNumberTextEdit.Text;
            _itemAssignment.ConditionOnReturn = (ConditionOnReturnTextEdit.EditValue ?? "").ToString();
            _itemAssignment.Price = Convert.ToDecimal(PriceTextEdit.Text);
            _itemAssignment.Notes = NotesTextEdit.Text;
            _itemAssignment.AssignmentDate = AssignmentDateDateEdit.DateTime;
            _itemAssignment.ReturnDate = ReturnDateDateEdit.EditValue as DateTime?;
            _itemAssignment.Count = Convert.ToInt32(CountSpinEdit.EditValue);
            _itemAssignment.IsDeleted = false;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(EmployeeIdLookUpEdit.EditValue?.ToString()))
            {
                XtraMessageBox.Show("يرجى اختيار الموظف.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (string.IsNullOrWhiteSpace(ItemIdLookUpEdit.EditValue?.ToString()))
            {
                XtraMessageBox.Show("يرجى اختيار مادة.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (checkEdit1.Checked)
            {
                return false;
            }
            if (Convert.ToDecimal(PriceTextEdit.Text) <= 0)
            {
                XtraMessageBox.Show("لا يمكن ان يكون السعر اقل او يساوي صفر", "خطأ في التحقق", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }

            if (string.IsNullOrWhiteSpace(AssignmentNumberTextEdit.Text))
            {
                XtraMessageBox.Show("يرجى إدخال رقم الاخراج.", "خطأ في التحقق", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }

            // if (string.IsNullOrWhiteSpace(ConditionOnReturnTextEdit.EditValue?.ToString()))
            // {
            //     XtraMessageBox.Show("يرجى اختيار حالة الصنف عند الإرجاع.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     return false;
            // }
            if (AssignmentDateDateEdit.DateTime == default)
            {
                XtraMessageBox.Show("يرجى اختيار تاريخ الاخراج.", "خطأ في التحقق", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }

            // if (ReturnDateDateEdit.DateTime == default)
            // {
            //     XtraMessageBox.Show("يرجى اختيار تاريخ الإرجاع.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     return false;
            // }
            if (Convert.ToInt32(CountSpinEdit.EditValue) > 0) return false;
            XtraMessageBox.Show("يجب أن تكون الكمية أكبر من صفر.", "خطأ في التحقق", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return true;
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                return;
            }

            try
            {
                FullItemAssignmentData();
                if (string.IsNullOrWhiteSpace(ItemAssignmentId))
                {
                    await _unitOfWork.ItemsAssignmentRepository.AddAsync(_itemAssignment);
                }
                else
                {
                    _itemAssignment.Ulid = ItemAssignmentId;
                    await _unitOfWork.ItemsAssignmentRepository.UpdateAsync(_itemAssignment.Ulid, _itemAssignment);
                }

                _unitOfWork.CommitAsync().Wait();
                XtraMessageBox.Show("تم حفظ الإسناد بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                XtraMessageBox.Show("حدث خطأ أثناء حفظ الإسناد. يرجى المحاولة مرة أخرى.", "خطأ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void ItemIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItemId = ItemIdLookUpEdit.EditValue;
                if (selectedItemId == null) return;
                var selectedItem = await _unitOfWork.ItemsRepository.GetByIdAsync(selectedItemId.ToString());
                if (selectedItem == null) return;
                PriceTextEdit.Text = selectedItem.Price.ToString(CultureInfo.InvariantCulture);
                StockEntryNumberTextEdit.Text = selectedItem.StockEntryNumber;
                StockEntryDateDateEdit.EditValue = selectedItem.StockEntryDate;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            var frm = new Items.ItemsOperationsFrom();
            frm.ShowDialog();
            await LoadLookupEdit();
        }

        private async void simpleButton3_Click(object sender, EventArgs e)
        {
            var frm = new Employees.EmployeesOperationsForm();
            frm.ShowDialog();
            await LoadLookupEdit();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            AssignmentDateDateEdit.EditValue = null;
        }
    }
}