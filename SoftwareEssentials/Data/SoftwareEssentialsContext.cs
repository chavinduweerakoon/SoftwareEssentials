using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SoftwareEssentials.Models
{
    public class SoftwareEssentialsContext : DbContext
    {
        public SoftwareEssentialsContext (DbContextOptions<SoftwareEssentialsContext> options)
            : base(options)
        {
        }

        public DbSet<SoftwareEssentials.Models.Subject> Subject { get; set; }
    }
}
