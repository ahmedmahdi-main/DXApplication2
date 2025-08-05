using System;
using DXApplication2.Services;
using MongoDB.Bson.Serialization.Attributes;


namespace DXApplication2.Entities;

public class Item : IAutoIncrementEntity
{
    [BsonId]
    public string ULID { get; set; } = UlidGenerator.GenerateUlid();
    public string Name { get; set; }
    public string Type { get; set; }
    public string SerialNumber { get; set; }
    public string Status { get; set; }
    public string Condition { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public DateTime PurchaseDate { get; set; }
    public string Notes { get; set; } = string.Empty;
    public int Id { get; set; }
}
