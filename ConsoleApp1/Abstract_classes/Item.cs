namespace Program;

public abstract class Item : IItem
{
    public string material;
    public int height;
    public int width;
    public int weight;
    public abstract void Take();
}