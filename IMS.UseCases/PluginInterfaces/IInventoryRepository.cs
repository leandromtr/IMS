using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
    }
}
