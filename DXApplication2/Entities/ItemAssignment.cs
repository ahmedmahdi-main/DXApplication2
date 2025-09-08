#nullable enable
using System;
using DXApplication2.Services;
using MongoDB.Bson.Serialization.Attributes;

namespace DXApplication2.Entities;


public class ItemAssignment : IAutoIncrementEntity
{
    [BsonId]
    public string Ulid { get; set; } = UlidGenerator.GenerateUlid();
    public string ItemId { get; set; } 
    public string EmployeeId { get; set; }
    public int Count { get; set; } = 1;
    public decimal Price { get; set; }
    public string? AssignmentNumber { get; set; }
    public DateTime? AssignmentDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public string? ConditionOnReturn { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
}
