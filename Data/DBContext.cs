using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Models
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Departaments> Departaments { get; set; }
        public DbSet<Seller> sellers { get; set; }
        public DbSet<SellerRecord> sellerRecords { get; set; }
    }
}
