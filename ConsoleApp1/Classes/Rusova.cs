namespace Program;

public class Rusova : Student
{
    public override void Run()
    {
        Console.WriteLine("Running");
    }

    public string Name = "Vika";

    public void Answer()
    {
        if (this.Name == "Vika")
        {
            Console.WriteLine("Answearing");
        }
        else
        {
            Console.WriteLine("not answer");
        }
    }
}