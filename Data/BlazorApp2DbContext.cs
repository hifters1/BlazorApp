using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class BlazorApp2DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Preference> Preferences { get; set; }

        public BlazorApp2DbContext(DbContextOptions<BlazorApp2DbContext> options) : base(options) { }

    }
}
