using DatabaseContext;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class LogService
    {
        static Database _context = new Database();

        public static List<Log> GetAll()
        {
            var logs = _context.Logs.ToList();

            return logs;
        }

        public static Log GetById(int Id)
        {
            var log = _context.Logs.FirstOrDefault(x => x.Id == Id);

            return log;
        }

        public static List<Log> GetByDate(DateTime dateTime)
        {
            var logs = _context.Logs.Where(x => x.AddedAt.Date == dateTime.Date).ToList();

            return logs;
        }

        public static Log Add(Log log)
        {
            _context.Logs.Add(log);
            _context.SaveChanges();

            return log;
        }
    }
}
