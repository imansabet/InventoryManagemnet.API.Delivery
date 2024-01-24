using System.ComponentModel.DataAnnotations;

namespace InventoryManagemnet.API.Delivery.DTO.InternalAPIModel.Request
{
    public class InventoryServiceRequest
    {
        [Key]
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
