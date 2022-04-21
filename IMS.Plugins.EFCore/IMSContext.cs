using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { InventoryId = 1, InventoryName = "Engine", Price=1000, Quantity = 1 },
                new Inventory { InventoryId = 2, InventoryName = "Body", Price=4000, Quantity = 1 },
                new Inventory { InventoryId = 3, InventoryName = "Seat", Price=500, Quantity = 5 },
                new Inventory { InventoryId = 4, InventoryName = "Wheel", Price=100, Quantity = 100 }
                );
        }
    }
}
