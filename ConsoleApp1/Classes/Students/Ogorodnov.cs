namespace Program;

public class Ogorodnov : Student
{
    private static string Hair;
    static Ogorodnov()
    { 
        Hair = "white";
    }
    public static void Walk()
    {
        Console.WriteLine("walking");
    }
    
    public override void Run()
    {
        Console.WriteLine("walking");
    }
}