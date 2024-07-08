using Microsoft.EntityFrameworkCore;
using PortfolioOkaBlazor.Components.Pages;
using PortfolioOkaBlazor.Domain;

namespace PortfolioOkaBlazor.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<EducationData> Educations { get; set; }
        public DbSet<SkillData> Skills { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationData>().HasKey(p => p.Id);
            modelBuilder.Entity<EducationData>().HasData(
                 new EducationData("National Chin-Yi University of Technology", "Master Degree - Computer Science", "GPA : 3.92", "#d4cfb1", "https://www.ncut.edu.tw/", "/images/logoncut.png"),
                 new EducationData("Bina Nusantara University", "Bachelor Degree - Computer Science", "GPA : 3.24", "cadetblue", "https://binus.ac.id/", "/images/logobinus.png"),
                 new EducationData("Politeknik Negeri Bandung", "Associate Degree - Computer Science", "GPA : 2.81", "#4E567E", "https://www.polban.ac.id/", "/images/logopolban.png")

            );

            modelBuilder.Entity<WorkExperience>().HasKey(p => p.Id);
            modelBuilder.Entity<WorkExperience>().HasData(
                 new WorkExperience("Xiangshun Information Co., Ltd", "Programmer", "Coding"),
                 new WorkExperience("Multimedia Security Laboratory - NCUT", "Research Assistant", "Coding"),
                  new WorkExperience("Fujitsu Indonesia", "Functional Developer", "Coding"),
                 new WorkExperience("PT. Lapi Divusi", "Programmer Internship", "Coding")

            );

            modelBuilder.Entity<SkillData>().HasKey(p => p.Id);
            modelBuilder.Entity<SkillData>().HasData(
                 new SkillData("C#", "Experienced in .NET development, including ASP.NET Core and Entity Framework."),
                 new SkillData("Front-End", "Proficient in HTML, CSS, JavaScript, and Blazor."),
                  new SkillData("Back-End", "Knowledgeable in databases, and API development."),
                 new SkillData("Project Management", "Familiar with Agile methodologies and version control systems like Git."),
                  new SkillData("Game Development", "Currently developing game using Godot Engine")

            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("OkaDataBase");
        }
    }
}
