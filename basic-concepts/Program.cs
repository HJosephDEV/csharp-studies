// See https://aka.ms/new-console-template for more information
using ClassTestNamespace;

Console.WriteLine("Hello, World!");
ClassTest a = new ClassTest();
a.Test();

// variables test
char letter = 'w';
var limit = 1;
int[] numberList = { 0, 1, 2, 3 };
var queryTest = from item in numberList where item == limit select item;


Console.WriteLine(letter);
Console.WriteLine(limit);
Console.WriteLine(numberList[3]);
Console.WriteLine(queryTest);

// methods

List<Product> products = new List<Product>
{
    new Product(1, "produto1"),
    new Product(2, "produto2"),
    new Product(3, "produto3")
};

string GetName(int productId)
{
    foreach (var product in products)
    {
        if (product.ProductId == productId) return product.ProductName;
    }

    return "";
}

Console.WriteLine(GetName(2));

//registers

Product produtoTest = new Product(1, "test");
Product produtoTest1 = produtoTest with { ProductId = 100 };
Product produtoTest2 = produtoTest;
produtoTest.ProductId = 10;

Console.WriteLine(produtoTest.ProductId);
Console.WriteLine(produtoTest1.ProductId);
Console.WriteLine(produtoTest2.ProductId);

int i = 0;

while (i < 10)
{
    Console.WriteLine($"while teste {i + 1}");
    i++;
}

for (int j = 1; j <= 10; j++)
{
    Console.WriteLine($"For Test {j}");
    if (j == 5) break;
}

public struct Product
{
    public int ProductId;
    public string ProductName;

    public Product(int productId, string productName)
    {
        ProductId = productId;
        ProductName = productName;
    }
}
