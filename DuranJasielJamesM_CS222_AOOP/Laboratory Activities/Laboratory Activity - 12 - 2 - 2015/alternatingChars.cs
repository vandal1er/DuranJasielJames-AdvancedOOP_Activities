using System;

public class AlternatingChars
{
    public static void Main(string[] args)
    {
        char first, second;
        int size;
        
        Console.Write("First character: ");
        first = Console.ReadLine()[0];
        
        Console.Write("Second character: ");
        second = Console.ReadLine()[0];
        
        Console.Write("Enter size: ");
        size = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < i+1; j ++)
            {
                if (j == i)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(first);
                    }
                    else
                    {
                        Console.Write(second);
                    }
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
        
        
    }
}
