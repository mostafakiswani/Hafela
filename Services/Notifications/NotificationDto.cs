using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Notifications
{
    public class NotificationDto
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Priority { get; set; }
        public string UserId { get; set; }
    }
}
