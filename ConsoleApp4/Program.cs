namespace ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        int num = 100;
        long numl = 10023l;
        float numf = 10.221f;
        decimal numd = 10.2345m;
        double numdbl = 10.2341;
        string str = "Hello World!";
        char ch = 'A';
        bool isActive = false;
        Console.WriteLine(
            $"int is {num}, long is {numl}, float is {numf}, decimal is {numd}, string is {str}, char is {ch}, boolean is {isActive}");
        int a = 100;
        decimal b = 99.1234m;
        var sum = a + b;
        Type type = sum.GetType();
        Console.WriteLine($"sum is {sum}"); // a is of int type, b is of decimal type and a+b is of decimal type.
        Console.WriteLine(type);
    }
}