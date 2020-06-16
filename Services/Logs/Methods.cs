﻿using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Logs
{
    public class Methods
    {
        public static void Add(string action)
        {
            var log = new Log();

            log.Action = action;
            log.AddedAt = Region.Methods.CurrentDateTime();

            var createdLog = LogService.Add(log);

        }

        public static void Add(string action, int userId)
        {
            var log = new Log();

            log.Action = string.Format("{0} For {1}", action, userId);
            log.AddedAt = Region.Methods.CurrentDateTime();

            var createdLog = LogService.Add(log);


        }


    }
}