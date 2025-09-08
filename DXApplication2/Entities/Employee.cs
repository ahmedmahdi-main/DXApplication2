#nullable enable
using DXApplication2.Services;
using MongoDB.Bson.Serialization.Attributes;


namespace DXApplication2.Entities;

public class Employee : IAutoIncrementEntity
{
    [BsonId]
    public string Ulid { get; set; } = UlidGenerator.GenerateUlid();
    public string Name { get; set; } = string.Empty;
    public string? Department { get; set; }
    public string? Position { get; set; }
    public string? NationalId { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public int Id { get; set; }
}