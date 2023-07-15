namespace Pertemuan_5;
class Program
{
    static void Main(string[] args)
    {

        Number number = new Number();

        Console.WriteLine($"Minimum #1 : {number.findMinimum(3, 1)}");
        Console.WriteLine($"Minimum #2 : {number.findMinimum(3, 2, 4)}");
        Console.WriteLine();
        Console.WriteLine($"Maximum #3 : {number.findMaximum(3, 1)}");
        Console.WriteLine($"Maximum #4 : {number.findMaximum(3, 2, 4)}");

        Console.ReadKey();
    }
}

