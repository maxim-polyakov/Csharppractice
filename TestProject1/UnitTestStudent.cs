using Program;
namespace TestProject1;

public class Students
{
    Program.Object obj0 = new Table();
    Program.Object obj1 = new Chair();
    Program.Object obj2 = new Computer();
    
    [Test]
    public void Test_Gorbulya()
    {   
        Student gar = new Gorbulya(this.obj0, this.obj1, this.obj2);
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
        Student gar = new Rusova(this.obj0, this.obj1, this.obj2);
        gar.Run();
    }
    
    [Test]
    public void Test_Sharov()
    {
        Student gar = new Sharov(this.obj0, this.obj1, this.obj2);
        gar.Run();
    }
    [Test]
    public void Test_Ogorodnov()
    {
        Ogorodnov.Walk();  
    } 
}