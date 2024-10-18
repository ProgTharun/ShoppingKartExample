namespace StoreModels
{
    public class LineItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public LineItem(int id, int quantity, Product product)
        {
            Id = id;
            Quantity = quantity;
            Product = product;
        }

        public double CalculateLineItemCost()
        {
            return Quantity * Product.CalculateDiscountedPrice();
        }
    }
}