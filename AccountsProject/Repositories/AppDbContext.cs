using Microsoft.EntityFrameworkCore;

namespace AccountsProject.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.Supplier> Suppliers { get; set; }
        public DbSet<Models.PurchaseOrder> PurchaseOrders { get; set; }
        //public DbSet<Models.PurchaseOrderLine> PurchaseOrderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public override int SaveChanges()
        {
            var changedEntriesCopy = ChangeTracker.Entries()
                            .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                            .ToList();

            DateTime savedTime = DateTime.Now;

            foreach (var entityEntry in changedEntriesCopy)
            {
                entityEntry.Property("UserID").CurrentValue = 1;

                if (entityEntry.State == EntityState.Added)
                    entityEntry.Property("Created").CurrentValue = savedTime;
                else if (entityEntry.State == EntityState.Modified)
                    entityEntry.Property("Updated").CurrentValue = savedTime;

                //if (entityEntry.Metadata.FindProperty("Created") != null && entityEntry.Property("Created").CurrentValue == null)
                //{
                //    entityEntry.Property("Created").CurrentValue = savedTime;
                //}

                //if (entityEntry.Metadata.FindProperty("Updated") != null)
                //{
                //    entityEntry.Property("Updated").CurrentValue = savedTime;
                //}
            }

            return base.SaveChanges();
        }
    }
}
