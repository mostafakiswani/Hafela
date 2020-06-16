using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Notifications
{
    public class SendNotification
    {
        public static void Send(User user)
        {
            string body = "Welcome User";

            var notification = new Notification();

            notification.Body = body;
            notification.UserId = user.Id;

            PushNotification.Push(user.DeviceToken, notification);
            Logs.Methods.Add(body, user.Id);

        }

        public static void Send(User user, string body)
        {

            var notification = new Notification();

            notification.Body = body;
            notification.UserId = user.Id;

            PushNotification.Push(user.DeviceToken, notification);
            Logs.Methods.Add(body, user.Id);

        }
        public static void Send(User user, string body, int busId)
        {

            var notification = new Notification();

            notification.Body = body;
            notification.UserId = user.Id;

            PushNotification.Push(user.DeviceToken, busId, notification);
            Logs.Methods.Add(body, user.Id);

        }

        public static void Send(List<User> users, string body)
        {
            foreach (var user in users)
            {
                var notification = new Notification();

                notification.Body = body;
                notification.UserId = user.Id;

                PushNotification.Push(user.DeviceToken, notification);
                Logs.Methods.Add(body, user.Id);

            }
        }


    }
}
