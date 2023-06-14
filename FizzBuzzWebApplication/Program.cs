
using FizzBuzzWebApplication;

class Program
{
    static void Main(string[] args)
    {
        int[] values = { 1, 2, 5, 15, 23 };
        FizzBuzzProcessor processor = new FizzBuzzProcessor();
        string[] results = processor.ProcessArrayValues(values);

        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine($"{values[i]}\t{results[i]}");
        }
    }
}

