namespace Program;

public class Pencil : Item
{
    public Pencil(string material, int width, int weight)
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