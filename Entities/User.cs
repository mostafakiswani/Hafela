using System;

namespace Entities
{
    public class User : BaseEntity
    {
        public string DeviceToken { get; set; }
        public bool IsBlocked { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
    }
}
