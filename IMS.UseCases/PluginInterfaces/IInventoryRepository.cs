using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {

        Task UpdateInventoryAsync(Inventory inventory);
        Task AddInventoryAsync(Inventory inventory);

        Task<Inventory?> GetInventoryAsync(int inventoryId);
        Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
    }
}
