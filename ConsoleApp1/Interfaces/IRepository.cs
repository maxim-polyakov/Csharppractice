namespace Program;

public interface IRepository<T>
{
    public Task SaveAsync();

    public List<T> GetAll();
}