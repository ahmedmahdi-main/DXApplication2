using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication2.Services;

public static class PublicMessages
{
    public static DialogResult Message(MessageType messageType, string message = "")
    {
        return messageType switch
        {
            MessageType.Save => XtraMessageBox.Show(message + "تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK,
                MessageBoxIcon.Information),
            MessageType.Delete => XtraMessageBox.Show(message + "تم الحذف بنجاح", "حذف", MessageBoxButtons.OK,
                MessageBoxIcon.Information),
            MessageType.Confirmation => XtraMessageBox.Show(message + "هل انت متاكد من القيام بهذه العملية", "تاكيد",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning),
            MessageType.Error => XtraMessageBox.Show(message + "حدث خطا في تنفيذ العملية", "تحذير",
                MessageBoxButtons.OK, MessageBoxIcon.Error),
            MessageType.Restore => XtraMessageBox.Show(message + "تم الاستعادة بنجاح", "استعادة",
                MessageBoxButtons.OK, MessageBoxIcon.Information),
            MessageType.Exception => XtraMessageBox.Show(message, "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error),
            MessageType.Warning => XtraMessageBox.Show(message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Asterisk),
            MessageType.Custome => XtraMessageBox.Show(message, "توضيح", MessageBoxButtons.OK, MessageBoxIcon.Asterisk),
            MessageType.PermissionDenied => XtraMessageBox.Show(message + "لا تمتلك صلاحية لهذا الامر", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk),
                        MessageType.NothingToUpdate => XtraMessageBox.Show(message + "لا يوجد شيء لتحديثه", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk),

            _ => throw new ArgumentOutOfRangeException(nameof(messageType), messageType, null)
        };
    }
}

public enum MessageType
{
    Save,
    Delete,
    Error,
    Warning,
    Confirmation,
    Custome,
    PermissionDenied,
    Exception,
    Restore,
    NothingToUpdate
}
