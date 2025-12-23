namespace Program;

public sealed class Dosaev : Student
{
    private static readonly Dosaev _instance = new Dosaev();
    
    
    public string Hairnt { get; private set; }

    public override void Run()
    {
        Console.WriteLine("dfdfdfdfdf");
    }
    
    public static Dosaev Instance
    {
        get { return _instance; }
    }
}