using InventoryManagemnet.API.Delivery.DTO.InternalAPIModel.Request;
using InventoryManagemnet.API.Delivery.DTO.InternalAPIModel.Response;

namespace InventoryManagemnet.API.Delivery.INfrastructure.Repository
{
    public interface IInventoryRepository
    {
        public interface IInventoryRepository
        {
            Task<List<InventoryServiceResponse>> GetAllInventoryItemsAsync();
            Task<InventoryServiceResponse> GetInventoryItemAsync(Guid productId);
            Task AddInventoryItemAsync(InventoryServiceRequest inventoryItem);
            Task UpdateInventoryItemAsync(Guid productId, InventoryServiceRequest updatedInventoryItem);
            Task DeleteInventoryItemAsync(Guid productId);
        }
    }
}
