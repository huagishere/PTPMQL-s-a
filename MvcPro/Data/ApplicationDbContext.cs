using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPro.Models;

namespace MvcPro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPro.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<MvcPro.Models.DaiLy> DaiLy { get; set; } = default!;
        public DbSet<MvcPro.Models.Employee> Employee { get; set; } = default!;
    }
}
