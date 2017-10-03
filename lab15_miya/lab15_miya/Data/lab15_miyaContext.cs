using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab15_miya.Models
{
    public class lab15_miyaContext : DbContext
    {
        public lab15_miyaContext (DbContextOptions<lab15_miyaContext> options)
            : base(options)
        {
        }

        public DbSet<lab15_miya.Models.Register> Register { get; set; }
    }
}
