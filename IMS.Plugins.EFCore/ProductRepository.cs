using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMSContext db;
        public ProductRepository(IMSContext db)
        {
            this.db = db;
        }

        //public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        //{
        //    return await this.db.Inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase) ||
        //        string.IsNullOrWhiteSpace(name)).ToListAsync();
        //}
        //public async Task AddInventoryAsync(Inventory inventory)
        //{
        //    if (db.Inventories.Any(x => x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
        //        return;
            
        //    this.db.Inventories.Add(inventory);
        //    await this.db.SaveChangesAsync();
        //}

        //public async Task UpdateInventoryAsync(Inventory inventory)
        //{
        //    if (db.Inventories.Any(x => x.InventoryId != inventory.InventoryId &&
        //        x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
        //        return;

        //        var inv = await this.db.Inventories.FindAsync(inventory.InventoryId);
        //    if (inventory != null)
        //    {
        //        inventory.InventoryName = inventory.InventoryName;
        //        inventory.Price = inventory.Price;
        //        inventory.Quantity = inventory.Quantity;

        //        await db.SaveChangesAsync();
        //    }
        //}
        public async Task<List<Product>> GetProductsByName(string name)
        {
            return await this.db.Products.Where(x => x.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                string.IsNullOrWhiteSpace(name)).ToListAsync();
        }
    }
}