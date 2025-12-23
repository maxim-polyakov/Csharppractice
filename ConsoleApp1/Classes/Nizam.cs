namespace Program;

public class Nizam : Student
{
    private static string Hair;
    static Nizam()
    { 
        Hair = "white";
    }
    public override void Run()
    {
        try
        {
           Console.WriteLine("Running");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Finished");
    }
}