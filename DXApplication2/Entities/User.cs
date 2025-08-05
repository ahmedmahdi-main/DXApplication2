using DXApplication2.Services;

namespace DXApplication2.Entities
{
    public class User : IAutoIncrementEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
    }
}
