using Microsoft.EntityFrameworkCore;
using TcketApi.Models;

namespace TcketApi.Data
{
    public class Ticket:DbContext
    {
        public Ticket(DbContextOptions<Ticket> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
