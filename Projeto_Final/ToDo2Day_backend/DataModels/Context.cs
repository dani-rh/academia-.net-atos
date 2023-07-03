using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ToDo2Day.Models;

namespace ToDo2Day.DataModels
{
    public class Context : DbContext
    {
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }

        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=toDo2Day;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItem>()
                .HasOne(ti => ti.User)
                .WithMany()
                .HasForeignKey(ti => ti.UserId);

            modelBuilder.Entity<TaskItem>()
                .HasOne(ti => ti.Tag)
                .WithMany()
                .HasForeignKey(ti => ti.TagId)
                .IsRequired(false);

            modelBuilder.Entity<User>().HasQueryFilter(e => e.DeletedAt == null);
            modelBuilder.Entity<TaskItem>().HasQueryFilter(e => e.DeletedAt == null);
            modelBuilder.Entity<Tag>().HasQueryFilter(e => e.DeletedAt == null);

            modelBuilder.Entity<User>()
                .Property(b => b.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<User>()
                .Property(b => b.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Tag>()
                .Property(b => b.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Tag>()
                .Property(b => b.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<TaskItem>()
                .Property(b => b.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<TaskItem>()
                .Property(b => b.UpdatedAt)
                .HasDefaultValueSql("getdate()");
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is User || e.Entity is TaskItem || e.Entity is Tag);

            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    ((dynamic)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
                else if (entityEntry.State == EntityState.Deleted)
                {
                    entityEntry.State = EntityState.Modified;
                    ((dynamic)entityEntry.Entity).DeletedAt = DateTime.Now;
                }

                ((dynamic)entityEntry.Entity).UpdatedAt = DateTime.Now;
            }

            return base.SaveChanges();
        }

    }
}
