using System;

public class FizzBuzz
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 15; i++)
        {
            if ((i+1) % 3 == 0)
            {
                Console.Write("Fizz");
                
            }
            if ((i+1) % 5 == 0)
            {
                Console.Write("Buzz");
                
            }
            if ((i+1) % 3 != 0 && (i+1) % 5 != 0)
            {
                Console.Write(i+1);
            }
            Console.WriteLine();
        }
    }
}
