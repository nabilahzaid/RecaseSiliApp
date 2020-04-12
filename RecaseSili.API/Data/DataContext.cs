using Microsoft.EntityFrameworkCore;
using RecaseSili.API.Models;

namespace RecaseSili.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Value> Values { get; set; }
    }
}