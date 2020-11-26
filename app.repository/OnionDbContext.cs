using app.domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace app.repository
{
    public class OnionDbContext : DbContext
    {
        public OnionDbContext(DbContextOptions<OnionDbContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
