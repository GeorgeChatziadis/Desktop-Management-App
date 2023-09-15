using System;
using System.Collections.Generic;
using System.Data.Entity;
using DAL.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL.Entities
{
    public class Context : DbContext
    {
        public Context() : base("name=ConnectionString")
        {
            this.Database.Log = s => System.Diagnostics.Debug.Write(s);
        }

        static Context()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>()); //Initializer για να κάνει migrate η database στην τελευταία έκδοση των αλλαγών που τυχόν έχουμε κάνει στο πρόγραμμα μας
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<MaterialCategories> MaterialCategories { get; set; }
        public DbSet<PriceForClient> PriceForClient { get; set; }
        public DbSet<Town> Town { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}
