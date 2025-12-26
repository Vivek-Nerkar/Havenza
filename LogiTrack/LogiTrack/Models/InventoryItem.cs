namespace LogiTrack.Models
{
    public class InventoryItem
    {
        public int ItemId { get; set; }
        public string? Item { get; set; }
        public int Quantity { get; set; }
        public string? Location { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Item} | Quantity: {Quantity} | Location: {Location}");
        }
    } 
}
