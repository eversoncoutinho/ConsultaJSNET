using JS_NET.Models;
using Microsoft.EntityFrameworkCore;

namespace JS_NET.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
