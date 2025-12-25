using Program;
namespace TestProject1;

public class Objects
{
    [Test]
    public void Test_Computer()
    {
        Program.Object computer = new Computer();
        computer.Stand();
    }
    [Test]
    public void Test_Table()
    {
        Program.Object table = new Table();
        table.Stand();
    }
    [Test]
    public void Test_Chair()
    {
        Program.Object chair = new Chair();
        chair.Stand();
    }
}