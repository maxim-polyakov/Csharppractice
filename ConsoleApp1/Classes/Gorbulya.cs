namespace Program;

public class Gorbulya : Student
{
    public string Hairnt { get; private set; }

    public Gorbulya(string hairnt)
    {
       this.Hairnt = hairnt;
    }
    public override void Run()
    {
        Console.WriteLine(Hairnt);
    }
}   
