namespace Program;

public class Rusova : Student
{
    public Object obj0 { get; private set; }
    public Object obj1 { get; private set; }
    public Object obj2 { get; private set; }
    
    
    public Rusova(Object obj0, Object obj1, Object obj2)
    {
        this.obj0 = obj0;
        this.obj1 = obj1;
        this.obj2 = obj2;
    }
    
    
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