using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFlavioReact.Model;

namespace WebFlavioReact.Config
{
    public class Context : Microsoft.EntityFrameworkCore.DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
