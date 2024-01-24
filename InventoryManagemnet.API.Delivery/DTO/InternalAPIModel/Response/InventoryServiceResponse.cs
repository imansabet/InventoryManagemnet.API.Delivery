using System.ComponentModel.DataAnnotations;

namespace InventoryManagemnet.API.Delivery.DTO.InternalAPIModel.Response
{
    public class InventoryServiceResponse
    {
        [Key]
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
