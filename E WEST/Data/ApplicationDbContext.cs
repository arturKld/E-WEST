using E_WEST.Models.Academic;
using E_WEST.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

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

            modelBuilder.Entity<TeacherDepartment>()
                .HasKey(td => new {td.TeacherId, td.DepartmentId}); // Составной ключ

            // Настройка связей
            modelBuilder.Entity<TeacherDepartment>()
                .HasOne(td => td.Teacher)
                .WithMany(t => t.Departments)
                .HasForeignKey(td => td.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeacherDepartment>()
                .HasOne(td => td.Department)
                .WithMany(d => d.TeacherDepartments)
                .HasForeignKey(td => td.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Настройка для Lesson (Занятие)
            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Subject)
                .WithMany(s => s.Lessons)
                .HasForeignKey(l => l.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Student)
                .WithMany(s => s.Lessons)
                .HasForeignKey(l => l.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Настройка для GradeBook (Зачётная книжка)
            modelBuilder.Entity<GradeBook>()
                .HasOne(g => g.Student)
                .WithMany(s => s.GradeBooks)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GradeBook>()
                .HasOne(g => g.Subject)
                .WithMany()
                .HasForeignKey(g => g.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            // Отключаем каскадное удаление для всех важных связей
            modelBuilder.Entity<Subject>()
                .HasOne(s => s.Teacher)
                .WithMany(t => t.Subjects)
                .HasForeignKey(s => s.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
