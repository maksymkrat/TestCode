class Program
{
    public static void Main(string[] args)
    {
        IChief chief = new ChiefProxy(new Chief());

        while (true)
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Welcome to Cooker");
            Console.WriteLine("===== order =====");

            IEnumerable<Order> orders = chief.GetOrders();
            foreach (var order in orders)
            {
                string status = chief.GetStatuses().First(s => s.Key == order.StatusID).Value;
                Console.WriteLine($"{order.Name}\t\t{status}");

            }

        }
    }
}

class ChiefProxy : IChief
{
    private readonly Chief _chief;
    private IDictionary<int, string> _statuses; 
    public ChiefProxy(Chief chief)
    {
        _chief = chief;
    }

    public IDictionary<int, string> GetStatuses()
    {
        if (_statuses is null)
        {
            _statuses = _chief.GetStatuses();
        }

        return _statuses;
    }

    public IEnumerable<Order> GetOrders()
    {
        return _chief.GetOrders();
    }
}


interface IChief 
{
    IDictionary<int, string> GetStatuses();
    IEnumerable<Order> GetOrders();

}
class  Order
{
    public Guid Id { get; set; } = new Guid();
    public string  Name { get; set; }
    public int  StatusID { get; set; }
}

class Chief 
{
    public IDictionary<int, string> GetStatuses()
    {
        Dictionary<int, string> statuses = new();
         statuses.Add(1,"ready");
         statuses.Add(2,"not ready");
         statuses.Add(3,"preparing");
         
         Thread.Sleep(2000);
         return statuses;
    }

    public IEnumerable<Order> GetOrders()
    {
        List<Order> orders = new List<Order>();
        orders.Add(new Order(){Name = "Burger", StatusID = RandomizeStatus()});
        orders.Add(new Order(){Name = "Pasta", StatusID = RandomizeStatus()});
        orders.Add(new Order(){Name = "Omlet", StatusID = RandomizeStatus()});
        return orders;
    }

    private static int RandomizeStatus() => new Random().Next(1, 4);
}