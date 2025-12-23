using Program;
namespace TestProject1;

public class Tests
{
    [Test]
    public void Test_Gorbulya()
    {
        Student gar = new Gorbulya("red");
        gar.Run();
    }
    
    [Test]
    public void Test_Nizam()
    {
        Student gar = new Nizam();
        gar.Run();
    }
    
    [Test]
    public void Test_Rusova()
    {
        Student gar = new Rusova();
        gar.Run();
    }
    
    [Test]
    public void Test_Sharov()
    {
        Student gar = new Sharov("glasses");
        gar.Run();
    }
}