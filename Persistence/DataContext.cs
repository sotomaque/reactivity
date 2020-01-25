using System;
using Domain;
using Microsoft.EntityFramework.DbContext;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DBSet<Value> Values { get; set; }
    }
}
