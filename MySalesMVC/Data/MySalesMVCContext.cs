using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySalesMVC.Models;

namespace MySalesMVC.Data
{
    public class MySalesMVCContext : DbContext
    {
        public MySalesMVCContext (DbContextOptions<MySalesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MySalesMVC.Models.SystemUser> SystemUser { get; set; }

        public DbSet<MySalesMVC.Models.Client> Client { get; set; }

        public DbSet<MySalesMVC.Models.Telephone> Telephone { get; set; }
    }
}
