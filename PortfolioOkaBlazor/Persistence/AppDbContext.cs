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
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationData>().HasKey(p => p.Id);
            modelBuilder.Entity<EducationData>().HasData(
                 new EducationData("National Chin-Yi University of Technology", "Master Degree - Computer Science", "3.92"),
                 new EducationData("Bina Nusantara University", "Bachelor Degree - Computer Science", "3.24"),
                 new EducationData("Politeknik Negeri Bandung", "Associate Degree - Computer Science", "2.81")

            );

            modelBuilder.Entity<WorkExperience>().HasKey(p => p.Id);
            modelBuilder.Entity<WorkExperience>().HasData(
                 new WorkExperience("Xiangshun Information Co., Ltd", "Programmer", "Coding"),
                 new WorkExperience("Multimedia Security Laboratory - NCUT", "Research Assistant", "Coding"),
                  new WorkExperience("Fujitsu Indonesia", "Functional Developer", "Coding"),
                 new WorkExperience("PT. Lapi Divusi", "Programmer Internship", "Coding")

            );

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("OkaDataBase");
        }
    }
}
