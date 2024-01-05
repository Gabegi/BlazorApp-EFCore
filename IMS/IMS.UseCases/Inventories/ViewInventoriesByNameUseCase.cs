using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository _iventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository iventoryRepository)
        {
            _iventoryRepository = iventoryRepository;
        }
        public async Task <IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await _iventoryRepository.GetInventoriesByNameAsync(name);
        }
    }
}
