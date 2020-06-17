using Entities;
using Services.Helpers;
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
            var Id = ConverterServices.ConvertGuid(user.Id);

            var notification = new NotificationDto() { Body = body, UserId = Id };

            NotificationPushServices.Push(user.DeviceToken, notification);
            LogsService.Add(body, Id);

        }

        public static void Send(User user, string body)
        {
            var Id = ConverterServices.ConvertGuid(user.Id);

            var notification = new NotificationDto() { Body = body, UserId = Id };

            NotificationPushServices.Push(user.DeviceToken, notification);
            LogsService.Add(body, Id);

        }
        public static void Send(User user, string body, int busId)
        {
            var Id = ConverterServices.ConvertGuid(user.Id);

            var notification = new NotificationDto() { Body = body, UserId = Id };

            NotificationPushServices.Push(user.DeviceToken, busId, notification);
            LogsService.Add(body, Id);

        }

        public static void Send(List<User> users, string body)
        {
            foreach (var user in users)
            {
                var Id = ConverterServices.ConvertGuid(user.Id);

                var notification = new NotificationDto() { Body = body, UserId = Id };

                NotificationPushServices.Push(user.DeviceToken, notification);
                LogsService.Add(body, Id);

            }
        }


    }
}
