using System;
using Domain.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.DataAccess
{
    public class SimpleAppContext : DbContext
    {
        public DbSet<EApplication> EApplications { get; set; }
        public SimpleAppContext(DbContextOptions<SimpleAppContext> options) : base(options)
        {
        }
    }
}
