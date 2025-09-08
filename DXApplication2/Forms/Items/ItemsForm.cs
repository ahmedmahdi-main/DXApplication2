using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication2.DataAccess;
using DXApplication2.Entities;
using DXApplication2.Services;

namespace DXApplication2.Forms.Items
{
    public partial class ItemsForm : XtraForm
    {
        private readonly UnitOfWork _unitOfWork;
        private IEnumerable<Item> _items;
        public ItemsForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _items = Enumerable.Empty<Item>();
        }

        private async void ItemsForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadItemsList();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred while loading items: \n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadItemsList()
        {
            _items = (await _unitOfWork.ItemsRepository.GetAllAsync())
                .Where(item => !item.IsDeleted).ToList();
            if (textEdit1.EditValue != null)
            {
                _items = _items
                    .Where(i => i.Name.Contains(textEdit1.EditValue.ToString(), StringComparison.OrdinalIgnoreCase)
                                || i.Type.Contains(textEdit1.EditValue.ToString(), StringComparison.OrdinalIgnoreCase)
                                || i.SerialNumber.Contains(textEdit1.EditValue.ToString(), StringComparison.OrdinalIgnoreCase)
                                || i.Brand.Contains(textEdit1.EditValue.ToString(), StringComparison.OrdinalIgnoreCase)
                                || i.Model.Contains(textEdit1.EditValue.ToString(), StringComparison.OrdinalIgnoreCase)
                                || i.StockEntryNumber.Contains(textEdit1.EditValue.ToString(), StringComparison.OrdinalIgnoreCase)
                                )
                    .ToList();
            }
            if (dateEdit1.EditValue != null)
            {
                _items = _items.Where(item => item.StockEntryDate == dateEdit1.DateTime);
            }
            gridControl1.DataSource = _items;
        }

        private async void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var itemId = Convert.ToString(gridView1.GetFocusedRowCellValue("Ulid"));

                var item = await _unitOfWork.ItemsRepository.GetByIdAsync(itemId);

                if (item == null) return;
                switch (e.Button.Tag.ToString())
                {
                    case "btn_edit":
                        {
                            var frm = new ItemsOperationsFrom { ItemUlid = itemId };
                            frm.ShowDialog();
                            break;
                        }
                    case "btn_delete":
                        {
                            if (XtraMessageBox.Show("هل تريد الحذف ؟", "", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                item.IsDeleted = true;
                                await _unitOfWork.ItemsRepository.UpdateAsync(itemId, item);
                                PublicMessages.Message(MessageType.Delete);
                            }

                            break;
                        }
                }

                await LoadItemsList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(@$"Exception {ex.Message}");
            }
        }

        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var frm = new ItemsOperationsFrom();
                frm.ShowDialog();
                await LoadItemsList();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //TODO print  IEnumerable<Item> items
        }

        private async void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                await LoadItemsList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                textEdit1.Text = string.Empty;
                dateEdit1.EditValue = null;
                await LoadItemsList();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void dateEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                await LoadItemsList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}