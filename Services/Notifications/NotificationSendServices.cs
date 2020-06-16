using Entities;
using Services.Logs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Notifications
{
    public class NotificationSendServices
    {
        public static void Send(User user)
        {
            string body = "Welcome User";

            var notification = new NotificationDto() { Body = body, UserId = user.Id};

            NotificationPushServices.Push(user.DeviceToken, notification);
            LogsService.Add(body, user.Id);

        }

        public static void Send(User user, string body)
        {

            var notification = new NotificationDto() { Body = body, UserId = user.Id };

            NotificationPushServices.Push(user.DeviceToken, notification);
            LogsService.Add(body, user.Id);

        }
        public static void Send(User user, string body, int busId)
        {

            var notification = new NotificationDto() { Body = body, UserId = user.Id };

            NotificationPushServices.Push(user.DeviceToken, busId, notification);
            LogsService.Add(body, user.Id);

        }

        public static void Send(List<User> users, string body)
        {
            foreach (var user in users)
            {
                var notification = new NotificationDto() { Body = body, UserId = user.Id };

                NotificationPushServices.Push(user.DeviceToken, notification);
                LogsService.Add(body, user.Id);

            }
        }


    }
}
