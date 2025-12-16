using Newtonsoft.Json;

namespace Program;

public class BaseRepository<T> : IRepository<T>
{
    protected List<T> _items;
    protected readonly string _filePath;
    protected int _nextId = 1;

    protected BaseRepository(string filePath)
    {
        _filePath = filePath;
        _items = new List<T>();
        Load();
    }

    private void Load()
    {
        if (!File.Exists(_filePath)) return;
        string json = File.ReadAllText(_filePath);
        _items = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
    }

    public virtual async Task SaveAsync()
    {
        string json = JsonConvert.SerializeObject(_items, Newtonsoft.Json.Formatting.Indented);
        await File.WriteAllTextAsync(_filePath, json);
    }

    public List<T> GetAll() => _items;
}