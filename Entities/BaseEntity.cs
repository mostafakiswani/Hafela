using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
