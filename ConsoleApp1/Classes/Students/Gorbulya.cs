namespace Program;

public class Gorbulya : Student
{
    public string Hairnt { get; private set; }

    public Object obj0 { get; private set; }
    
    public Object obj1 { get; private set; }
    
    public Object obj2 { get; private set; }

    public Gorbulya(Object obj0, Object obj1, Object obj2)
    {
       this.obj1 = obj1;
       this.obj0 = obj0;
       this.obj2 = obj2;
    }
    public override void Run()
    {
        Console.WriteLine(Hairnt);
    }
}   
