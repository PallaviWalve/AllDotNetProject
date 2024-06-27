using Microsoft.EntityFrameworkCore;

namespace CodeFirstWithReferentialIntigrity.Models
{
    public class InstituteDBContext : DbContext
    {
        public InstituteDBContext()
        {
                
        }

        public InstituteDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Course> CourseTable { get; set; }

        public DbSet<Topic> TopicTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=InstituteDB;Integrated Security=true;Trust Server Certificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
