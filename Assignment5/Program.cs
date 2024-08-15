// See https://aka.ms/new-console-template for more information
class Assignment5
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("enter b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("performing addition:");
        add(a, b);
        Console.WriteLine("performing subraction:");
        sub(a, b);
    }
    public static void add(int x, int y)
    {
        Console.WriteLine($"{x} + {y} = {x + y}");
    }

    public static void sub(int x, int y)
    {
        Console.WriteLine($"{x} - {y} = {x-y}");
    }
}