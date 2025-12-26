namespace LogiTrack.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? CustomerName { get; set; }   
        public DateTime DataPlaced { get; set; }
        public List<InventoryItem>? Items { get; set; }

        public void AddItem(InventoryItem item)
        {
            if (Items == null)
            {
                Items = new List<InventoryItem>();
            }
            Items.Add(item);
        }
        public void RemoveItem(InventoryItem item)
        {
            Items?.Remove(item);
        }
        public void GetOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderId} | Customer: {CustomerName} | Date Placed: {DataPlaced}");
            if (Items != null && Items.Count > 0)
            {
                Console.WriteLine("Items in Order:");
                foreach (var item in Items)
                {
                    item.DisplayInfo();
                }
            }
            else
            {
                Console.WriteLine("No items in this order.");
            }
        }
    }
}
