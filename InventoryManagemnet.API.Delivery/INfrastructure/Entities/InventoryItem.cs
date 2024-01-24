namespace InventoryManagemnet.API.Delivery.INfrastructure.Entities
{
    public class InventoryItem
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
