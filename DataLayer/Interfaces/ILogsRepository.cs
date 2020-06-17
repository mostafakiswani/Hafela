using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface ILogsRepository
    {
        void MakeImportant(Guid id);

    }
}
