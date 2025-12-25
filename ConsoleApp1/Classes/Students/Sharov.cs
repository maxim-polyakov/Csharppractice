namespace Program;

public class Sharov : Student
{
    public string Glasses { get; private set; }
    
    public Object  obj0 { get; private set; }
    public Object  obj1 { get; private set; }
    public Object  obj2 { get; private set; }
    public Sharov(Object obj0, Object obj1, Object obj2)
    {
        this.obj0 = obj0;
        this.obj1 = obj1;
        this.obj2 = obj2;
    }
     public override void Run()
    {
        Console.WriteLine(Glasses);
    }
}