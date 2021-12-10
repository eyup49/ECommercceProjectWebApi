using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Contexts
{
    public class ECommercceProjectWebApiDbContext:DbContext
    {
        public ECommercceProjectWebApiDbContext(DbContextOptions<ECommercceProjectWebApiDbContext> options):base(options)
        {

        }
        public ECommercceProjectWebApiDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
