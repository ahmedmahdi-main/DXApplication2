using DevExpress.XtraEditors;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DXApplication2.DataAccess;
using DXApplication2.Entities;
using DXApplication2.Enums;
using DXApplication2.Services;
using static System.Enum;

namespace DXApplication2.Forms.Items
{
    public partial class ItemsOperationsFrom : XtraForm
    {
        private readonly UnitOfWork _unitOfWork;
        private Item _currentItem;
        public string ItemUlid;
        public ItemsOperationsFrom()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private async void ItemsOperationsFrom_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLookupEditsData();
                LoadItemData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void LoadLookupEditsData()
        {
            // StatusLookUpEdit.Properties.DataSource = GetValues(typeof(ItemStatus)).Cast<ItemStatus>()
            //     .Select(status => new { Id = status.ToString().Replace('_',' ') }).ToList();

            // StatusLookUpEdit.Properties.DisplayMember = "Name";
            // StatusLookUpEdit.Properties.DisplayMember = "Id";
            // StatusLookUpEdit.Properties.ValueMember = "Id";

            ConditionLookUpEdit.Properties.DataSource = GetValues(typeof(ItemCondition))
                .Cast<ItemCondition>()
                .Select(condition => new { Id = condition })
                .ToList();

            //ConditionLookUpEdit.Properties.DisplayMember = "Name";
            ConditionLookUpEdit.Properties.DisplayMember = "Id";
            ConditionLookUpEdit.Properties.ValueMember = "Id";
        }
        private async void LoadItemData()
        {

            try
            {
                if (string.IsNullOrWhiteSpace(ItemUlid))
                {
                    return;
                }
                _currentItem = await _unitOfWork.ItemsRepository.GetByIdAsync(ItemUlid);
                if (_currentItem != null)
                {
                    NameTextEdit.Text = _currentItem.Name;
                    TypeTextEdit.Text = _currentItem.Type;
                    SerialNumberTextEdit.Text = _currentItem.SerialNumber;
                    // StatusLookUpEdit.EditValue = _currentItem.Status;
                    PriceTextEdit.Text = _currentItem.Price.ToString(CultureInfo.InvariantCulture);
                    StockEntryNumberTextEdit.Text = _currentItem.StockEntryNumber;
                    StockEntryDateEdit.EditValue = _currentItem.StockEntryDate;
                    ConditionLookUpEdit.EditValue = _currentItem.Condition;
                    BrandTextEdit.Text = _currentItem.Brand;
                    ModelTextEdit.Text = _currentItem.Model;
                    PurchaseDateDateEdit.EditValue = _currentItem.PurchaseDate;
                    PurchaseNumberTextEdit.Text = _currentItem.PurchaseNumber;
                    NotesTextEdit.Text = _currentItem.Notes;


                }
                else
                {
                    XtraMessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred while loading item data: \n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FullItemData()
        {
            _currentItem ??= new Item();
            _currentItem.Name = NameTextEdit.Text;
            _currentItem.Type = TypeTextEdit.Text;
            _currentItem.SerialNumber = SerialNumberTextEdit.Text;
            // _currentItem.Status = StatusLookUpEdit.EditValue?.ToString();
            _currentItem.Condition = ConditionLookUpEdit.EditValue?.ToString();
            _currentItem.Price = Convert.ToDecimal(PriceTextEdit.Text);
            _currentItem.StockEntryDate = StockEntryDateEdit.DateTime;
            _currentItem.StockEntryNumber = StockEntryNumberTextEdit.Text;
            _currentItem.Brand = BrandTextEdit.Text;
            _currentItem.Model = ModelTextEdit.Text;
            _currentItem.PurchaseDate = PurchaseDateDateEdit.DateTime;
            _currentItem.PurchaseNumber = PurchaseNumberTextEdit.Text;
            _currentItem.Notes = NotesTextEdit.Text;
        }

        private bool ValidateItemData()
        {
            if (string.IsNullOrWhiteSpace(NameTextEdit.Text))
            {
                PublicMessages.Message(MessageType.Warning, "حقل اسم المادة مطلوب");
                return false;
            }
            if (checkEdit1.Checked)
            {
                return true;
            }
            if (string.IsNullOrWhiteSpace(TypeTextEdit.Text))
            {
                PublicMessages.Message(MessageType.Warning, "حقل نوع المادة مطلوب");
                return false;
            }

            if (Convert.ToDecimal(PriceTextEdit.Text) <= 0)
            {
                PublicMessages.Message(MessageType.Warning, "لا يمكن ان يكون السعر اقل او يساوي صفر");
                return false;
            }
            // if (string.IsNullOrWhiteSpace(SerialNumberTextEdit.Text))
            // {
            //     PublicMessages.Message(MessageType.Warning, "حقل الرقم التسلسلي مطلوب");
            // }
            // if (StatusLookUpEdit.EditValue == null)
            // {
            //     PublicMessages.Message(MessageType.Warning, "حقل الحالة مطلوب");
            // }
            // if (ConditionLookUpEdit.EditValue == null)
            // {
            //     PublicMessages.Message(MessageType.Warning, "حقل الحالة مطلوب");
            // }
            if (string.IsNullOrWhiteSpace(BrandTextEdit.Text))
            {
                PublicMessages.Message(MessageType.Warning, "حقل الجهة المجهزة مطلوب");
                return false;
            }
            // if (string.IsNullOrWhiteSpace(ModelTextEdit.Text))
            // {
            //     PublicMessages.Message(MessageType.Warning, "حقل الموديل مطلوب");
            // }
            if (PurchaseDateDateEdit.EditValue == null)
            {
                PublicMessages.Message(MessageType.Warning, "حقل تاريخ التجهيز مطلوب");
                return false;
            }
            if (string.IsNullOrWhiteSpace(PurchaseNumberTextEdit.Text))
            {
                PublicMessages.Message(MessageType.Warning, "حقل رقم التجهيز مطلوب");
                return false;
            }
            if (StockEntryDateEdit.EditValue == null)
            {
                PublicMessages.Message(MessageType.Warning, "حقل تاريخ الادخال المخزني مطلوب");
                return false;
            }
            if (string.IsNullOrWhiteSpace(StockEntryNumberTextEdit.Text))
            {
                PublicMessages.Message(MessageType.Warning, "حقل رقم الادخال المخزني مطلوب");
                return false;
            }
            return true;
        }

        private void ClearItemData()
        {
            NameTextEdit.Text = string.Empty;
            TypeTextEdit.Text = string.Empty;
            SerialNumberTextEdit.Text = string.Empty;
            // StatusLookUpEdit.EditValue = null;
            PriceTextEdit.Text = 0.ToString();
            StockEntryDateEdit.EditValue = null;
            StockEntryNumberTextEdit.Text = string.Empty;
            ConditionLookUpEdit.EditValue = null;
            BrandTextEdit.Text = string.Empty;
            ModelTextEdit.Text = string.Empty;
            PurchaseDateDateEdit.EditValue = null;
            PurchaseNumberTextEdit.Text = string.Empty;
            NotesTextEdit.Text = string.Empty;
            _currentItem = new Item();
        }
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                FullItemData();
                if (!ValidateItemData())
                {
                    return;
                }
                if (_currentItem.Id == 0)
                {
                    _currentItem.Ulid = UlidGenerator.GenerateUlid();
                    await _unitOfWork.ItemsRepository.AddAsync(_currentItem);

                }
                else
                {
                    await _unitOfWork.ItemsRepository.UpdateAsync(ItemUlid, _currentItem);

                }
                await _unitOfWork.CommitAsync();
                PublicMessages.Message(MessageType.Save);
                ClearItemData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred while saving item data: \n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}