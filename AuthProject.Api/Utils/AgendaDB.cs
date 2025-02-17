using AuthProject.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthProject.Api.Utils
{
    public class AgendaDB(DbContextOptions<AgendaDB> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
