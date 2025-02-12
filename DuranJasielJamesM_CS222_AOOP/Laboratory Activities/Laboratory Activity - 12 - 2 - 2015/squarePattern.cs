using System;

public class SquarePattern
{
    public static void Main(string[] args)
    {
        int n, y;
        Console.Write("Enter n: ");
        n = int.Parse(Console.ReadLine());
        
        Console.Write("Enter y: ");
        y = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != y-1)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
