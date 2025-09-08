using DXApplication2.Enums;
using DXApplication2.Services;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DXApplication2.Entities;

/// <summary>
/// (اختياري) View/Document للأرصدة الحالية لتسريع القراءة
/// يُحدّث عبر Aggregation بعد كل حركة.
/// </summary>

[BsonIgnoreExtraElements]
public class InventoryBalance
{
    [BsonId]
    public string Ulid { get; set; } = UlidGenerator.GenerateUlid();

    [BsonRequired]
    public string ItemUlid { get; set; } = default!;

    // [BsonRequired, BsonRepresentation(BsonType.Int32)]
    // public ItemStatus Status { get; set; }

    [BsonRequired, BsonRepresentation(BsonType.Int32)]
    public ItemCondition Condition { get; set; }

    [BsonRequired]
    public int Quantity { get; set; }
}