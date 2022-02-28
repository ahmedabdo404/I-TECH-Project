namespace ITech_Project.Models
{
    public class ShoppingCartItem
    {

        public int Id { get; set; }
        public Product product { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
