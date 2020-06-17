using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Log : BaseEntity
    {
        public string Action { get; set; }
        public bool IsImportant { get; set; } = false;

    }
}
