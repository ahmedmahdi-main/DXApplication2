#nullable enable
using DXApplication2.Entities;

namespace DXApplication2.Services;

    public static class LoginInfo
    {
        public static string UserName { get; set; } = "Anonymous User";
        public static int UserId { get; set; }
        public static int GroupId { get; set; }
        public static User? CurrentUser { get; set; }
        
    }