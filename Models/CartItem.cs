namespace GuitarShop.Models
{
    public class CartItem
    {
            public int Id { get; set; }
            public int GuitarId { get; set; }
            public int Quantity { get; set; }
            public int UserId { get; set; }

            public Customer Username { get; set; }
            public Customer Password { get; set; }
        // Add more properties as needed (e.g., UserId, timestamp, etc.).
    }
}
