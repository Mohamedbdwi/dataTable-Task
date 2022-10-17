using Microsoft.EntityFrameworkCore;

namespace Student_task_datatable.Models
{
    public class StudentDbContext : DbContext
    {
        //Configuration DbContext
        private readonly IConfiguration configuration;

        public StudentDbContext()
        {

        }


        public DbSet<Student> students { get; set; }


        public StudentDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SEOFCOF\\SQLEXPRESS;Database=ElbaitTask;Integrated Security=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
