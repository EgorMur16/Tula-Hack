using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>().Property(z => z.Id).UseIdentityColumn();
            builder.Entity<Student>().Property(z => z.Name).HasMaxLength(100);
            builder.Entity<Student>().Property(z => z.SerName).HasMaxLength(100);

            builder.Entity<Student>().HasData(
                new Student
                {
                    Id= 1,
                    Name = "Сергей",
                    SerName = "Фигурин",
                    TgNick = "@ggt",
                    Number = 89202711047m,
                    DataTravell = DateTime.Now.AddYears(-20),
                    Price = 999m
                }
                );
            base.OnModelCreating(builder);
        }

        public DbSet <Student> Students { get; set; }
        
    }
}
