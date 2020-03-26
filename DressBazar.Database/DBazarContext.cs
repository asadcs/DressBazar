using DressBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressBazar.Database
{
    public class DBazarContext:DbContext,IDisposable
    {
        public DBazarContext():base("DressBazarConnection")
        { }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
