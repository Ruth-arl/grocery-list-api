namespace Grocery_list_api.Models
{
    public class GroceryItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double  UnitPrice { get; set; }
    }
}
