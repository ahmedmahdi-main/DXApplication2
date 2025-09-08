// لو كانت الـ Enums داخل هذا النيمسبيس
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using DXApplication2.Enums;
using DXApplication2.Services;

// using DXApplication2.Common; // لو كان مولد ULID هنا (حسب مشروعك)

namespace DXApplication2.Entities
{
    /// <summary>
    /// دفتر الحركات المخزنية: كل عملية تغيِّر كمية مادة من حالة/وضع إلى حالة/وضع أخرى.
    /// قاعدة: Quantity > 0 دائماً (الخصم/الإضافة يتحدد من From/To).
    /// </summary>
    [BsonIgnoreExtraElements]
    public class InventoryTransaction
    {
        [BsonId]
        public string Ulid { get; set; } = UlidGenerator.GenerateUlid();

        /// <summary>معرّف المادة (يرتبط بـ Item.ULID)</summary>
        [BsonRequired]
        public string ItemUlid { get; set; } = default!;

        /// <summary>الكمية المنقولة (موجبة دائماً)</summary>
        [BsonRequired]
        public int Quantity { get; set; }

        /// <summary>الحالة السابقة (قد تكون null عند التوريد الأول)</summary>
        // [BsonRepresentation(BsonType.Int32)]
        // public ItemStatus? FromStatus { get; set; }

        /// <summary>الوضع/الCondition السابق (قد تكون null عند التوريد الأول)</summary>
        [BsonRepresentation(BsonType.Int32)]
        public ItemCondition? FromCondition { get; set; }

        /// <summary>الحالة اللاحقة</summary>
        // [BsonRequired, BsonRepresentation(BsonType.Int32)]
        // public ItemStatus ToStatus { get; set; }

        /// <summary>الوضع/الCondition اللاحق</summary>
        [BsonRequired, BsonRepresentation(BsonType.Int32)]
        public ItemCondition ToCondition { get; set; }

        /// <summary>سبب الحركة (توريد، تسليم عهدة، إرجاع، إصلاح...)</summary>
        [BsonRequired, BsonRepresentation(BsonType.Int32)]
        public InventoryReason Reason { get; set; }

        /// <summary>مرجع الحركة (مثلاً ULID لسجل ItemAssignment أو أمر شراء)</summary>
        public string? RefULID { get; set; }

        /// <summary>نوع المرجع: "ItemAssignment", "PurchaseOrder", ... (اختياري)</summary>
        public string? RefType { get; set; }

        /// <summary>تاريخ تسجيل الحركة (UTC)</summary>
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime When { get; set; } = DateTime.UtcNow;

        /// <summary>اسم المستخدم/النظام الذي أنشأ الحركة (اختياري)</summary>
        public string? CreatedBy { get; set; }

        /// <summary>ملاحظات إضافية</summary>
        public string Notes { get; set; } = string.Empty;
    }

    #pragma warning disable CS0618

    
    
}
