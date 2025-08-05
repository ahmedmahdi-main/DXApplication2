using DXApplication2.Entities;

namespace DXApplication2.Data;
using System.Collections.Generic;
public static class DemoData
{


public static List<Employee> employees =
[
    new Employee
    {
        Name = "أحمد كريم",
        Department = "الصيانة",
        Position = "فني",
        NationalID = "123456789",
        Phone = "07701234567",
        Email = "ahmed.karim@example.com"
    },

    new Employee
    {
        Name = "سارة علي",
        Department = "البرمجة",
        Position = "مبرمج",
        NationalID = "987654321",
        Phone = "07809876543",
        Email = "sarah.ali@example.com"
    },

    new Employee
    {
        Name = "محمد حسين",
        Department = "الشؤون الإدارية",
        Position = "موظف إداري",
        NationalID = "1122334455",
        Phone = "07501122334",
        Email = "m.hussein@example.com"
    },

    new Employee
    {
        Name = "رنا جبار",
        Department = "الحسابات",
        Position = "محاسب",
        NationalID = "9988776655",
        Phone = "07909988776",
        Email = "rana.jabbar@example.com"
    },

    new Employee
    {
        Name = "علي سامي",
        Department = "المخزن",
        Position = "أمين مخزن",
        NationalID = "5566778899",
        Phone = "07707766554",
        Email = "ali.sami@example.com"
    }
];

}