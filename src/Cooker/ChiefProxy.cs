namespace Cooker;

internal class ChiefProxy : IChief
{
    private readonly Chief _chief;

    private IDictionary<int, string>? _statuses;

    public ChiefProxy(Chief chief)
    {
        _chief = chief;
    }

    public IEnumerable<Order> GetOrders()
    {
        Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()\n");

        return _chief.GetOrders();
    }

    public IDictionary<int, string> GetStatuses()
    {
        if (_statuses is null)
        {
            _statuses = _chief.GetStatuses();
        }

        return _statuses;
    }
}
