namespace Program;

public class Program
{
    public static void PrintCollection<T>(List<T> items)
    {
        if (!items.Any())
        {
            Console.WriteLine("Список пуст.");
            return;
        }
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
    
    public static async Task Main(string[] args)
    {
        string clientsFile = "clients.json";
        var clientRepo = new ClientRepository(clientsFile);
        
        Console.WriteLine("--- Начальный список клиентов ---");
        PrintCollection(clientRepo.GetAll());

        Console.WriteLine("\n--- Добавляем нового клиента ---");
        clientRepo.Add("Иван Петров", "ivan@test.com");
        PrintCollection(clientRepo.GetAll());

        string ordersFile = "orders.json";
        var orderRepo = new OrderRepository(ordersFile);

        Console.WriteLine("\n--- Начальный список заказов ---");
        PrintCollection(orderRepo.GetAll());

        Console.WriteLine("\n--- Добавляем новые заказы для клиента с ID 1 ---");
        orderRepo.Add(1, "Разработка логотипа", 15000m, DateOnly.FromDateTime(DateTime.Now.AddDays(10)));
        orderRepo.Add(1, "Настройка рекламы", 25000m, DateOnly.FromDateTime(DateTime.Now.AddDays(20)));
        PrintCollection(orderRepo.GetAll());

        Console.WriteLine("\n--- Ищем все заказы для клиента с ID 1 ---");
        var client1Orders = orderRepo.GetOrdersByClientId(1);
        PrintCollection(client1Orders);

        // Сохраняем все изменения
        await clientRepo.SaveAsync();
        await orderRepo.SaveAsync();
        Console.WriteLine("\nВсе данные сохранены.");
        
        Ogorodnov.Walk(); 
        Student dos = Dosaev.Instance;
        
        Student niz = new Nizam();
        
        Student niz1 = new Rusova();
        

        Console.ReadLine();
    }
}

