using DatabaseContext;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class LogsRepository
    {
        static Database _context = new Database();

        public List<Log> GetAll()
        {
            return _context.Logs.ToList();
        }

        public Log GetById(int Id)
        {
            return _context.Logs.FirstOrDefault(x => x.Id == Id);
        }

        public List<Log> GetByDate(DateTime dateTime)
        {
            return _context.Logs.Where(x => x.AddedAt.Date == dateTime.Date).ToList();
        }

        public Log Add(Log log)
        {
            _context.Logs.Add(log);
            _context.SaveChanges();

            return log;
        }
    }
}
