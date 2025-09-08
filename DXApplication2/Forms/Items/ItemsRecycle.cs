using DevExpress.XtraEditors;
using DXApplication2.DataAccess;
using DXApplication2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication2.Services;

namespace DXApplication2.Forms.Items
{
    public partial class ItemsRecycle : XtraForm
    {
        private readonly UnitOfWork _unitOfWork;
        private IEnumerable<Item> _items;

        public ItemsRecycle()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private async void ItemsRecycle_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadItemsList();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private async Task LoadItemsList()
        {
            _items = (await _unitOfWork.ItemsRepository.GetAllAsync())
                .Where(item => item.IsDeleted).ToList();
            if (textEdit1.EditValue != null)
            {
                _items = _items
                    .Where(i => i.Name.Contains(textEdit1.EditValue.ToString() ?? string.Empty,
                                    StringComparison.OrdinalIgnoreCase)
                                || i.Type.Contains(textEdit1.EditValue.ToString() ?? string.Empty,
                                    StringComparison.OrdinalIgnoreCase)
                                || i.SerialNumber.Contains(textEdit1.EditValue.ToString() ?? string.Empty,
                                    StringComparison.OrdinalIgnoreCase)
                                || i.Brand.Contains(textEdit1.EditValue.ToString() ?? string.Empty,
                                    StringComparison.OrdinalIgnoreCase)
                                || i.Model.Contains(textEdit1.EditValue.ToString() ?? string.Empty,
                                    StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            gridControl1.DataSource = _items;
        }

        private async void repositoryItemButtonEdit1_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                        if (XtraMessageBox.Show("هل تريد الحذف نهائيا؟", "", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            await _unitOfWork.ItemsRepository.DeleteAsync(itemId);
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

        private async void RecycleItemButtonEdit_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                // only handle the "return" button
                if (!string.Equals(e.Button?.Tag as string, "btn_return", StringComparison.Ordinal))
                    return;

                // get the selected item's ULID
                var itemId = gridView1.GetFocusedRowCellValue("Ulid") as string;
                if (string.IsNullOrWhiteSpace(itemId))
                    return;

                // confirm with the user
                var confirm = XtraMessageBox.Show(
                    "هل تريد استعادة هذه المادة؟",
                    "تأكيد",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                    return;

                try
                {
                    // fetch item
                    var item = await _unitOfWork.ItemsRepository.GetByIdAsync(itemId);
                    if (item is null)
                        return;

                    // already restored? nothing to do
                    if (!item.IsDeleted)
                    {
                        PublicMessages.Message(MessageType.NothingToUpdate);
                        return;
                    }

                    // restore + persist
                    item.IsDeleted = false;
                    await _unitOfWork.ItemsRepository.UpdateAsync(itemId, item);

                    PublicMessages.Message(MessageType.Restore);
                    await LoadItemsList();
                }
                catch (Exception ex)
                {
                    // log + show friendly message
                    Console.WriteLine($@"[RestoreItem] {ex}");
                    XtraMessageBox.Show("حدث خطأ أثناء الاستعادة. الرجاء المحاولة مرة أخرى.",
                        "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"[RestoreItem] {ex}");
                XtraMessageBox.Show("حدث خطأ أثناء الاستعادة. الرجاء المحاولة مرة أخرى.",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                textEdit1.Text = string.Empty;
                await LoadItemsList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(@$"Exception {ex.Message}");
            }
        }
    }
}