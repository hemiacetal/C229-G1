using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C229_G1.Models
{
    public class EFLogRepository : ILogRepository
    {
        private ApplicationDbContext context;

        public EFLogRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Log> Logs => context.Logs;

        public void Save(Log log)
        {
            context.Logs.Add(log);
            context.SaveChanges();
        }
    }
}
