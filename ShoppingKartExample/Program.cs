namespace StoreApplication
{
    using StoreModels;

    class Program
    {
        static void Main()
        {
            // Pre-populated Product List (with 4 items)
            var laptop = new Product(3001, "Laptop", 1000, 10);
            var mouse = new Product(3002, "Mouse", 50, 5);
            var monitor = new Product(3003, "Monitor", 300, 15);
            var keyboard = new Product(3004, "Keyboard", 100, 0);
            
            // Pre-populated Line Items
            var lineItem1 = new LineItem(2001, 1, laptop);
            var lineItem2 = new LineItem(2002, 2, mouse);
            var lineItem3 = new LineItem(2003, 1, monitor);
            var lineItem4 = new LineItem(2004, 1, keyboard);
            

            // Pre-populated Orders
            var order1 = new Order(1001, new DateTime(2024, 10, 8), new List<LineItem> { lineItem1, lineItem2 });
            var order2 = new Order(1002, new DateTime(2024, 10, 7), new List<LineItem> { lineItem3, lineItem4 });
           

            // Pre-populated Customer
            var customer = new Customer(101, "Tharun", new List<Order> { order1, order2 });

            // Display Customer Details and Orders
            customer.DisplayCustomerDetails();
        }
    }
}