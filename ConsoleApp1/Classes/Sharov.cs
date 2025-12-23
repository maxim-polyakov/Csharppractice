namespace Program;

public class Sharov : Student
{
    public string Glasses { get; private set; }

    public Sharov(string glasses)
    {
        this.Glasses = glasses;
    }
     public override void Run()
    {
        Console.WriteLine(Glasses);
    }
}