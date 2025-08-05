using System;
using System.Collections.Generic;
using System.Linq;

namespace DXApplication2.Services;

public static class EnumProvider
{
    public static List<EnumItem> GetEnumItems<TEnum>() where TEnum : Enum
    {
        return Enum.GetValues(typeof(TEnum))
            .Cast<TEnum>()
            .Select(e => new EnumItem
            {
                Id = Convert.ToInt32(e),
                Name = e.ToString().Replace('_',' ')
            })
            .ToList();
    }
    public class EnumItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}