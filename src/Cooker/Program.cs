using Cooker;

IChief chief = new ChiefProxy(new Chief());

while(true)
{
    Thread.Sleep(2000);

    Console.Clear();

    Console.WriteLine("Welcome to Cooker!\n");
    Console.WriteLine("========= Orders =========\n");

    IEnumerable<Order> orders = chief.GetOrders();

    foreach(Order order in orders)
    {
        string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;

        Console.WriteLine($"{order.Name}\t\t{status}");
    }
}