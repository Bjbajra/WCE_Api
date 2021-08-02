using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WCE_Api.Entities;

namespace WCE_Api.Data
{
    public class DataContext : IdentityDbContext<AppUser, AppRole, int, IdentityUserClaim<int>,
    AppUserRole, IdentityUserLogin<int>,IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DbSet<Course> Courses{get;set;}
        public DbSet<Student> Students { get; set; }
        public DbSet<ShoppingCartItems> ShoppingCartItems {get; set;}
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
            .HasMany(ur => ur.UserRoles)
            .WithOne(u => u.User)
            .HasForeignKey(ur => ur.UserId)
            .IsRequired();

            builder.Entity<AppRole>()
            .HasMany(ar => ar.UserRoles)
            .WithOne(ar => ar.Role)
            .HasForeignKey(ar => ar.RoleId)
            .IsRequired();
        }
    }
}