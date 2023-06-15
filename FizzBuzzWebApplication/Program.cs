
using FizzBuzzWebApplication;
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] values = { "1","3","5","","15","A","23"};
        FizzBuzzProcessor processor = new FizzBuzzProcessor();
        string[] results = processor.ProcessArrayValues(values);

        for (int i = 0; i < values.Length; i++)
        {
            if(string.IsNullOrEmpty(results[i]))
            {
                Console.WriteLine($"{values[i]}\tDivided {values[i]} by {3}\r\n\tDivided {values[i]} by {5}");
            }
            else { 
            Console.WriteLine($"{values[i]}\t{results[i]}");
            }
        }
    }
}

