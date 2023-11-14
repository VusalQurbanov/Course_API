using Course_API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Runtime.CompilerServices;

namespace Course_API.DAL
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Course> Course { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<LessonDays> LessonDays { get; set; }
        public DbSet<LessonHours> LessonHours { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 1,
                    CourseName = "CodeAcademy"
                },
                new Course
                {
                    CourseId = 2,
                    CourseName = "Matrix"
                });
            modelBuilder.Entity<LessonDays>().HasData(
                new LessonDays
                {
                    LessonDaysId = 1,
                    Day = "Bazar Ertesi"
                    
                },
                new LessonDays
                {
                    LessonDaysId= 2,
                    Day = "Cersenbe Axsami"
                },
                new LessonDays
                {
                    LessonDaysId= 3,
                    Day = "Cersenbe"
                },
                new LessonDays 
                { 
                    LessonDaysId = 4,
                    Day = "Cume Axsami" 
                },
                new LessonDays
                {
                    LessonDaysId= 5,
                    Day = "Cume"
                },
                new LessonDays
                {
                    LessonDaysId= 6,
                    Day = "Senbe"
                });
            modelBuilder.Entity<LessonHours>().HasData(
                new LessonHours
                {
                    LessonHoursId = 1,
                    Hours = "10:00-12:00"
                },
                new LessonHours
                {
                    LessonHoursId= 2,
                    Hours="12:00-14:00"
                },
                new LessonHours
                {
                    LessonHoursId= 3,
                    Hours = "14:00-16:00"
                },
                new LessonHours
                {
                    LessonHoursId= 4,
                    Hours = "16:00-18:00"
                },
                new LessonHours
                {
                    LessonHoursId= 5,
                    Hours = "18:00-20:00"
                });
        } 
        
    }
    
}