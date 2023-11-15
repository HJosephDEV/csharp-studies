namespace ClassTest2Namespace;

public class ClassTest2
{
    public string FirstName { get; set; } = "bbbb";
    public string LastName { get; set; } = "aaa";

    public void ShowFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}
