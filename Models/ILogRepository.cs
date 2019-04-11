using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
{
    public interface ILogRepository
    {
        IQueryable<Log> Logs { get; }
        void Save(Log log);
    }
}
