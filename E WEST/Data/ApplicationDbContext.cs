using E_WEST.Models.Academic;
using E_WEST.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_WEST.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Teacher-Department (many-to-many)
            modelBuilder.Entity<TeacherDepartment>()
                .HasKey(td => new { td.TeacherId, td.DepartmentId });

            // Ограничения для оценок
            modelBuilder.Entity<Lesson>()
                .Property(l => l.GradeValue)
                .HasAnnotation("Range", new[] { 2, 5 });

            // Запрет каскадного удаления
            modelBuilder.Entity<Subject>()
                .HasOne(s => s.Teacher)
                .WithMany(t => t.Subjects)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GradeBook>()
                .HasOne(g => g.Teacher)
                .WithMany(t => t.GradeBooks)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
