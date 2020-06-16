using System;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string DeviceToken { get; set; }
        public bool IsBlocked { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
    }
}
