
using Datingapp.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace Datingapp.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values {get; set;}
    }
}