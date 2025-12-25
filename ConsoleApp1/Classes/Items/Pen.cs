namespace Program;

public class Pen : Item
{
    public Pen(string material, int width, int weight)
    {
        base.material = material;
        base.width = width;
        base.weight = weight;
    }

    public override void Take()
    {
        Console.WriteLine("Pen Taken");
    }
}