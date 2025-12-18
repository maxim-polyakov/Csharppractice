namespace Program;

public class OrderRepository : BaseRepository<Order>
{
    public OrderRepository(string filePath) : base(filePath)
    {
        if (_items.Any())
        {
            _nextId = _items.Cast<Order>().Max(o => o.Id) + 1;
        }
    }

    public Order Add(int clientId, string description, decimal amount, DateOnly dueDate)
    {
        var order = new Order(_nextId++, clientId, description, amount, dueDate);
        _items.Add(order);
        return order;
    }

    public List<Order> GetOrdersByClientId(int clientId)
    {
        return _items.Cast<Order>().Where(o => o.ClientId == clientId).ToList();
    }
}