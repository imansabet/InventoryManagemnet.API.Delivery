using InventoryManagemnet.API.Delivery.DTO.InternalAPIModel.Request;
using InventoryManagemnet.API.Delivery.DTO.InternalAPIModel.Response;
using InventoryManagemnet.API.Delivery.INfrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagemnet.API.Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryManagementController : ControllerBase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryManagementController(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<InventoryServiceResponse>>> GetAllInventoryItems()
        {
            var inventoryItems = await _inventoryRepository.GetAllInventoryItemsAsync();
            return Ok(inventoryItems);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<InventoryServiceResponse>> GetInventoryItem(Guid productId)
        {
            var inventoryItem = await _inventoryRepository.GetInventoryItemAsync(productId);

            if (inventoryItem == null)
                return NotFound();

            return Ok(inventoryItem);
        }

        [HttpPost]
        public async Task<ActionResult> AddInventoryItem(InventoryServiceRequest inventoryItem)
        {
            await _inventoryRepository.AddInventoryItemAsync(inventoryItem);
            return CreatedAtAction(nameof(GetInventoryItem), new { productId = inventoryItem.ProductId }, inventoryItem);
        }

        [HttpPut("{productId}")]
        public async Task<ActionResult> UpdateInventoryItem(Guid productId, InventoryServiceRequest updatedInventoryItem)
        {
            await _inventoryRepository.UpdateInventoryItemAsync(productId, updatedInventoryItem);
            return NoContent();
        }

        [HttpDelete("{productId}")]
        public async Task<ActionResult> DeleteInventoryItem(Guid productId)
        {
            await _inventoryRepository.DeleteInventoryItemAsync(productId);
            return NoContent();
        }
    }
}
