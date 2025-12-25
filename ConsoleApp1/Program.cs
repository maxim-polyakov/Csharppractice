namespace Program;

public class Program
{
    
    public static async Task Main(string[] args)
    {
        Ogorodnov.Walk();
        
        Object obj0 = new Table();
        Object obj1 = new Chair();
        Object obj2 = new Computer();
        
        Student dos = new Dosaev(obj0, obj1, obj2);
        
        Student niz = new Nizam();
        
        Student niz1 = new Rusova(obj0, obj1, obj2);
        

        Console.ReadLine();
    }
}

