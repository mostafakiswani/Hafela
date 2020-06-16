using CorePush.Google;
using DatabaseContext;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Notifications
{
    public class NotificationPushServices
    {
         const string firebaseApiKey = Variables.FirebaseApiKey;
         const string firebaseUser = Variables.FirebaseUser;
         const string appName = Variables.AppName;
         const string priority = "High";

        public async static void Push(string deviceToken, NotificationDto notification)
        {
            notification.Priority = priority;
            notification.Title = appName;

            using var fcmClient = new FcmSender(firebaseApiKey, firebaseUser);
            await fcmClient.SendAsync(deviceToken, new { data = notification });
        }

        public async static void Push(string deviceToken, int busId, NotificationDto notification)
        {
            notification.Priority = priority;
            notification.Title = appName;

            using var fcmClient = new FcmSender(firebaseApiKey, firebaseUser);
            await fcmClient.SendAsync(deviceToken, new { data = notification, busId = busId });
        }


    }
}
