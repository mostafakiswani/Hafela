using DatabaseContext;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class LogsRepository : ILogsRepository
    {
        private IRepository<Log> repository;
        public LogsRepository(IRepository<Log> repository)
        { this.repository = repository; }


        public void MakeImportant(Guid id)
        {
            var logFromDb = repository.GetById(id);

            logFromDb.IsImportant = true;

            repository.Update(logFromDb);

        }


    }
}
