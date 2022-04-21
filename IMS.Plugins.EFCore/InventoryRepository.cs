using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        Task<IEnumerable<Inventory>> IInventoryRepository.GetInventoriesByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}