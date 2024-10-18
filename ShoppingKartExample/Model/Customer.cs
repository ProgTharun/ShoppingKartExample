namespace StoreModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int id, string name, List<Order> orders)
        {
            Id = id;
            Name = name;
            Orders = orders;
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer Id: {Id}");
            Console.WriteLine($"Customer Name: {Name} ");
            Console.WriteLine($"Order Count: {Orders.Count}\n");

            for (int i = 0; i < Orders.Count; i++)
            {
                Orders[i].DisplayOrderDetails(i + 1);
            }
        }
    }
}