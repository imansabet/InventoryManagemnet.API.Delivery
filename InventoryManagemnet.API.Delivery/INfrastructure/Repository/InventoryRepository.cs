using InventoryManagemnet.API.Delivery.DTO.InternalAPIModel.Request;
using InventoryManagemnet.API.Delivery.DTO.InternalAPIModel.Response;
using InventoryManagemnet.API.Delivery.INfrastructure.Configuration;
using InventoryManagemnet.API.Delivery.INfrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagemnet.API.Delivery.INfrastructure.Repository
{
        public class InventoryRepository : IInventoryRepository
        {
            private readonly ApplicationDbContext _context;

            public InventoryRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<InventoryServiceResponse>> GetAllInventoryItemsAsync()
            {
                return await _context.InventoryItems
                    .Select(item => new InventoryServiceResponse
                    {
                        ProductId = item.ProductId,
                        ProductName = item.ProductName,
                        Quantity = item.Quantity
                    })
                    .ToListAsync();
            }

            public async Task<InventoryServiceResponse> GetInventoryItemAsync(Guid productId)
            {
                var inventoryItem = await _context.InventoryItems.FindAsync(productId);

                if (inventoryItem == null)
                    return null;

                return new InventoryServiceResponse
                {
                    ProductId = inventoryItem.ProductId,
                    ProductName = inventoryItem.ProductName,
                    Quantity = inventoryItem.Quantity
                };
            }

            public async Task AddInventoryItemAsync(InventoryServiceRequest inventoryItem)
            {
                _context.InventoryItems.Add(new InventoryItem
                {
                    ProductId = inventoryItem.ProductId,
                    ProductName = inventoryItem.ProductName
                });

                await _context.SaveChangesAsync();
            }

            public async Task UpdateInventoryItemAsync(Guid productId, InventoryServiceRequest updatedInventoryItem)
            {
                var existingItem = await _context.InventoryItems.FindAsync(productId);

                if (existingItem == null)
                    return;

                existingItem.ProductName = updatedInventoryItem.ProductName;

                await _context.SaveChangesAsync();
            }

            public async Task DeleteInventoryItemAsync(Guid productId)
            {
                var inventoryItem = await _context.InventoryItems.FindAsync(productId);

                if (inventoryItem == null)
                    return;

                _context.InventoryItems.Remove(inventoryItem);
                await _context.SaveChangesAsync();
            }
        }
    }

