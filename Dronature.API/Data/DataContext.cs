using System;
using Dronature.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Dronature.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Value> Values { get; set; }
    }
}
