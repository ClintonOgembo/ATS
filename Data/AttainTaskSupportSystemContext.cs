using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AttainTaskSupportSystem.Models;

namespace AttainTaskSupportSystem.Data
{
    public class AttainTaskSupportSystemContext : DbContext
    {
        public AttainTaskSupportSystemContext (DbContextOptions<AttainTaskSupportSystemContext> options)
            : base(options)
        {
        }

        public DbSet<AttainTaskSupportSystem.Models.Admin> Admin { get; set; } = default!;
        public DbSet<AttainTaskSupportSystem.Models.Staff> Staff { get; set; } = default!;
        public DbSet<AttainTaskSupportSystem.Models.Client> Client { get; set; } = default!;
    }
}
