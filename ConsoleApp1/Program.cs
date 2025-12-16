namespace Program;

public class Program
{
    public static void PrintClients(List<Client> clients)
    {
        if (!clients.Any())
        {
            Console.WriteLine("Список клиентов пуст.");
            return;
        }
        foreach (var client in clients)
        {
            Console.WriteLine(client);
        }
    }
    
    public static async Task Main(string[] args)
    {
        string clientsFile = "clients.json";
        var clientRepo = new ClientRepository(clientsFile);

        Console.WriteLine("--- Начальный список клиентов (загружен из файла, если он был) ---");
        PrintClients(clientRepo.GetAll());

        Console.WriteLine("\n--- Добавляем нового клиента ---");
        clientRepo.Add("Новый Клиент", "new@client.com");
        PrintClients(clientRepo.GetAll());

        // Сохраняем все изменения в файл
        await clientRepo.SaveAsync();
        Console.WriteLine("\nДанные сохранены в файл. Перезапустите программу, чтобы увидеть загрузку.");

        Console.ReadLine();
    }
}

