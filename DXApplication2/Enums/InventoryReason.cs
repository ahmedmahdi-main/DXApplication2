namespace DXApplication2.Enums;

/// <summary>
/// أسباب الحركة المخزنية (للتقارير والتدقيق).
/// </summary>
public enum InventoryReason
{
    OpeningBalance = 0,   // رصيد افتتاحي
    Purchase = 1,         // توريد/شراء
    AssignmentIssue = 2,  // تسليم عهدة لموظف
    AssignmentReturn = 3, // إرجاع عهدة من موظف
    Damage = 4,           // تلف داخل المخزن/أثناء الاستخدام
    RepairOut = 5,        // إرسال للإصلاح (ينقل إلى حالة/وضع "معطلة" مثلاً)
    RepairIn = 6,         // عودة من الإصلاح (إرجاعها إلى "متاحة")
    WriteOff = 7,         // شطب/تقاعد
    AdjustIncrease = 8,   // تسوية جرد (زيادة)
    AdjustDecrease = 9    // تسوية جرد (نقص)
}