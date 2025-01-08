using Elsewedy_Platform2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Data
{
    public class AppDbContext:DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       public DbSet<Cousre_ac> cousre_As { get; set; }
       public DbSet<Cousre_soft> cousre_Softs { get; set; }
       public DbSet<Student> students { get; set; }
       public DbSet<Instractor_Software> instractor_Softwares { get; set; }
       public DbSet<Teacher> teachers { get; set; }
       public DbSet<Video_ac> video_ac { get; set; }
       public DbSet<Video_soft> video_soft { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
