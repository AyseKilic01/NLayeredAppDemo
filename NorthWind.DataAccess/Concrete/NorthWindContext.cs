using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NorthWind.DataAccess.Concrete
{
    public class NorthWindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
