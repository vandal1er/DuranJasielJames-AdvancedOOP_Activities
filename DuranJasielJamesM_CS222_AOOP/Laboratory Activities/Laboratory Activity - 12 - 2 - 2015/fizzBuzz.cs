using System;

public class FizzBuzz
{
    public static void Main(string[] args)
    {
        int upBound;
        
        Console.Write("Enter upper bound: ");
        upBound = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= upBound; i++)
        {
            if ((i) % 3 == 0)
            {
                Console.Write("Fizz");
                
            }
            if ((i) % 5 == 0)
            {
                Console.Write("Buzz");
                
            }
            if ((i) % 3 != 0 && (i) % 5 != 0)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
