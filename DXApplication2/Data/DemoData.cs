using System;
using DXApplication2.Entities;

namespace DXApplication2.Data;

using Services;
using System.Collections.Generic;

public static class DemoData
{
   
    public static readonly List<Employee> Employees =
    [
        new Employee
        {
            Name = "أحمد كريم",
            Department = "الصيانة",
            Position = "فني",
            NationalId = "123456789",
            Phone = "07701234567",
            Email = "ahmed.karim@example.com"
        },

        new Employee
        {
            Name = "سارة علي",
            Department = "البرمجة",
            Position = "مبرمج",
            NationalId = "987654321",
            Phone = "07809876543",
            Email = "sarah.ali@example.com"
        },

        new Employee
        {
            Name = "محمد حسين",
            Department = "الشؤون الإدارية",
            Position = "موظف إداري",
            NationalId = "1122334455",
            Phone = "07501122334",
            Email = "m.hussein@example.com"
        },

        new Employee
        {
            Name = "رنا جبار",
            Department = "الحسابات",
            Position = "محاسب",
            NationalId = "9988776655",
            Phone = "07909988776",
            Email = "rana.jabbar@example.com"
        },

        new Employee
        {
            Name = "علي سامي",
            Department = "المخزن",
            Position = "أمين مخزن",
            NationalId = "5566778899",
            Phone = "07707766554",
            Email = "ali.sami@example.com"
        }
    ];
}

public static class ItemDemoData
{
    public static List<Item> GetDemoItems()
    {
        return
        [
            new Item
            {
                Id = 1, Ulid = UlidGenerator.GenerateUlid(), Name = "Laptop", Type = "Electronics",
                SerialNumber = "SN10001", Status = "Active", Condition = "New", Brand = "Dell", Model = "XPS 13",
                PurchaseDate = new DateTime(2024, 4, 10), PurchaseNumber = "PN10001", Notes = "Assigned to IT"
            },

            new Item
            {
                Id = 2, Ulid = UlidGenerator.GenerateUlid(), Name = "Office Chair", Type = "Furniture",
                SerialNumber = "SN10002", Status = "Active", Condition = "Good", Brand = "Ikea", Model = "Markus",
                PurchaseDate = new DateTime(2023, 7, 22), PurchaseNumber = "PN10002", Notes = ""
            },

            new Item
            {
                Id = 3, Ulid = UlidGenerator.GenerateUlid(), Name = "Printer", Type = "Electronics",
                SerialNumber = "SN10003", Status = "Inactive", Condition = "Used", Brand = "HP", Model = "LaserJet Pro",
                PurchaseDate = new DateTime(2022, 3, 15), PurchaseNumber = "PN10003", Notes = "Needs service"
            },

            new Item
            {
                Id = 4, Ulid = UlidGenerator.GenerateUlid(), Name = "Monitor", Type = "Electronics",
                SerialNumber = "SN10004", Status = "Active", Condition = "New", Brand = "Samsung", Model = "U28E590D",
                PurchaseDate = new DateTime(2025, 1, 5), PurchaseNumber = "PN10004", Notes = ""
            },

            new Item
            {
                Id = 5, Ulid = UlidGenerator.GenerateUlid(), Name = "Desk", Type = "Furniture",
                SerialNumber = "SN10005", Status = "Active", Condition = "Good", Brand = "Herman Miller",
                Model = "Aeron", PurchaseDate = new DateTime(2023, 5, 18), PurchaseNumber = "PN10005", Notes = ""
            },

            new Item
            {
                Id = 6, Ulid = UlidGenerator.GenerateUlid(), Name = "Router", Type = "Electronics",
                SerialNumber = "SN10006", Status = "Active", Condition = "New", Brand = "TP-Link",
                Model = "Archer AX6000", PurchaseDate = new DateTime(2024, 8, 12), PurchaseNumber = "PN10006",
                Notes = "For main office"
            },

            new Item
            {
                Id = 7, Ulid = UlidGenerator.GenerateUlid(), Name = "Projector", Type = "Electronics",
                SerialNumber = "SN10007", Status = "Inactive", Condition = "Used", Brand = "Epson", Model = "EB-X41",
                PurchaseDate = new DateTime(2021, 10, 30), PurchaseNumber = "PN10007", Notes = "Bulb needs replacement"
            },

            new Item
            {
                Id = 8, Ulid = UlidGenerator.GenerateUlid(), Name = "Keyboard", Type = "Electronics",
                SerialNumber = "SN10008", Status = "Active", Condition = "New", Brand = "Logitech", Model = "K780",
                PurchaseDate = new DateTime(2025, 6, 11), PurchaseNumber = "PN10008", Notes = ""
            },

            new Item
            {
                Id = 9, Ulid = UlidGenerator.GenerateUlid(), Name = "Mouse", Type = "Electronics",
                SerialNumber = "SN10009", Status = "Active", Condition = "New", Brand = "Logitech",
                Model = "MX Master 3", PurchaseDate = new DateTime(2025, 6, 11), PurchaseNumber = "PN10009", Notes = ""
            },

            new Item
            {
                Id = 10, Ulid = UlidGenerator.GenerateUlid(), Name = "Whiteboard", Type = "Furniture",
                SerialNumber = "SN10010", Status = "Active", Condition = "Good", Brand = "Quartet", Model = "Infinity",
                PurchaseDate = new DateTime(2022, 12, 1), PurchaseNumber = "PN10010", Notes = ""
            },

            new Item
            {
                Id = 11, Ulid = UlidGenerator.GenerateUlid(), Name = "Tablet", Type = "Electronics",
                SerialNumber = "SN10011", Status = "Active", Condition = "New", Brand = "Apple", Model = "iPad Air",
                PurchaseDate = new DateTime(2025, 2, 20), PurchaseNumber = "PN10011", Notes = "For design team"
            },

            new Item
            {
                Id = 12, Ulid = UlidGenerator.GenerateUlid(), Name = "Headset", Type = "Electronics",
                SerialNumber = "SN10012", Status = "Active", Condition = "New", Brand = "Sony", Model = "WH-1000XM4",
                PurchaseDate = new DateTime(2025, 7, 2), PurchaseNumber = "PN10012", Notes = ""
            },

            new Item
            {
                Id = 13, Ulid = UlidGenerator.GenerateUlid(), Name = "Smartphone", Type = "Electronics",
                SerialNumber = "SN10013", Status = "Active", Condition = "New", Brand = "Samsung", Model = "Galaxy S24",
                PurchaseDate = new DateTime(2025, 3, 15), PurchaseNumber = "PN10013", Notes = "For sales team"
            },

            new Item
            {
                Id = 14, Ulid = UlidGenerator.GenerateUlid(), Name = "Scanner", Type = "Electronics",
                SerialNumber = "SN10014", Status = "Inactive", Condition = "Used", Brand = "Canon",
                Model = "imageFORMULA", PurchaseDate = new DateTime(2020, 8, 25), PurchaseNumber = "PN10014",
                Notes = "Needs maintenance"
            },

            new Item
            {
                Id = 15, Ulid = UlidGenerator.GenerateUlid(), Name = "Coffee Machine", Type = "Appliance",
                SerialNumber = "SN10015", Status = "Active", Condition = "Good", Brand = "Nespresso", Model = "Vertuo",
                PurchaseDate = new DateTime(2023, 9, 6), PurchaseNumber = "PN10015", Notes = "For kitchen"
            }
        ];
    }
}


