using Microsoft.EntityFrameworkCore;

namespace StudentPortfolio.Models
{
    public class StudentDBcontext:DbContext
    {
        public StudentDBcontext(DbContextOptions<StudentDBcontext> options):base(options)
        {

        }
        public DbSet<StudentModel> Students { get; set; }
    }
}
