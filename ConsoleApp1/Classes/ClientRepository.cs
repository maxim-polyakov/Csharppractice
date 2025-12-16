namespace Program;

public class ClientRepository: BaseRepository<Client>
{
    public ClientRepository(string filePath) : base(filePath)
    {
        if (_items.Any())
        {
            _nextId = _items.Cast<Client>().Max(c => c.Id) + 1;
        }
    }

    public Client Add(string name, string email)
    {
        var client = new Client(_nextId++, name, email, DateTime.Now);
        _items.Add(client);
        return client;
    }

    public Client? GetById(int id)
    {
        return _items.Cast<Client>().FirstOrDefault(c => c.Id == id);
    }
}