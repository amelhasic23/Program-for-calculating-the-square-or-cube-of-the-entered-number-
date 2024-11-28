using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite broj n: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 != 0)
        {
            Console.WriteLine($"Kvadrat broja ({n}) je {n * n}");
        }
        else
        {
            Console.WriteLine($"Kub broja ({n}) je {n * n * n}");
        }
    }
}
