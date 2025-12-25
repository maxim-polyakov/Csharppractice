using Program;
namespace TestProject1;

public class Items
{
    [Test]
    public void Test_Pen()
    {
        Item pen = new Pen("plastic", 2, 1);
        pen.Take();
    }
    [Test]
    public void Test_Pencil()
    {
        Item pencil = new Pen("plastic", 2, 1);
        pencil.Take();
    }
}