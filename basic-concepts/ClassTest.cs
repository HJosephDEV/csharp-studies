namespace ClassTestNamespace;

public class ClassTest
{
    private string _name;

    public ClassTest(string name)
    {
        _name = name;
    }

    public void Test()
    {
        Console.WriteLine($"hello {_name}");
    }
}
