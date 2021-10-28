namespace Cooker;

public interface IChief
{
    IDictionary<int, string> GetStatuses();

    IEnumerable<Order> GetOrders();
}
