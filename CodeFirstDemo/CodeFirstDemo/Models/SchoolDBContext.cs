using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CodeFirstDemo.Models
{
    public class SchoolDBContext:DbContext
    {
        public SchoolDBContext()
        {

        }

        public SchoolDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\Sqlexpress;Database=SchoolDB;Integrated Security=true;Trust Server Certificate=true");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
