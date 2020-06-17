using DataLayer;
using Entities;
using Services.Region;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Logs
{
    public class LogsService
    {
        private static IRepository<Log> repository;
        public LogsService(IRepository<Log> repository)
        { LogsService.repository = repository; }

        public static void Add(string action)
        {
            var log = new Log() { Action = action, CreatedAt = RegionServices.CurrentDateTime()};

            repository.Insert(log);

        }

        public static void Add(string action, string userId)
        {
            var log = new Log() { Action = string.Format("{0} For {1}", action, userId), CreatedAt = RegionServices.CurrentDateTime() };

            repository.Insert(log);

        }


    }
}
