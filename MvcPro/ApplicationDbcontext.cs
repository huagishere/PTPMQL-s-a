using Microsoft.EntityFrameworkCore;
using MvcPro.Models;
namespace MvcPro.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        { }
        public DbSet<Person> Person { get; set; }
    }
}