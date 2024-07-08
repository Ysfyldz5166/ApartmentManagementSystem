using Microsoft.EntityFrameworkCore;
using Entities;

namespace ApartmentManagementSystem.DataAccess
{
    public class ApartmentManagementContext : DbContext
    {
        public ApartmentManagementContext(DbContextOptions<ApartmentManagementContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<Income> Incomes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Apartment)
                .WithMany(a => a.Users)
                .HasForeignKey(u => u.ApartmentId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Notifications)
                .WithOne(n => n.User)
                .HasForeignKey(n => n.UserID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Expenses)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<FamilyMember>()
                .HasOne(fm => fm.Apartment)
                .WithMany(a => a.FamilyMembers)
                .HasForeignKey(fm => fm.ApartmentID);
        }
    }
}
