using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Log
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
