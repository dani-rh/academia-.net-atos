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
            //não trazer as tags deletadas
            modelBuilder.Entity<Tag>().HasQueryFilter(e => e.DeletedAt == null);

            //preencher automaticamente o campo CreatedAt e UpdatedAt
            modelBuilder.Entity<Tag>()
               .Property(b => b.CreatedAt)
               .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Tag>()
                .Property(b => b.UpdatedAt)
                .HasDefaultValueSql("getdate()");
        }
        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is Tag);

            foreach (var entityEntry in entries)
            {
                //se a entidade estiver sendo adicionada o CreatedAt é definido como a data e hora atual
                if (entityEntry.State == EntityState.Added)
                {
                    ((dynamic)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
                //se a entidade estiver sendo excluída o DeletedAt é definido como a data e hora atual
                else if (entityEntry.State == EntityState.Deleted)
                {
                    entityEntry.State = EntityState.Modified;//exclusão da entidade é tratada como uma atualização no banco de dados
                    ((dynamic)entityEntry.Entity).DeletedAt = DateTime.Now;
                }
                //para toda modificação, a UpdatedAt é definida como a data e hora atual
                ((dynamic)entityEntry.Entity).UpdatedAt = DateTime.Now;
            }

            return base.SaveChanges();
        }

    }
}
