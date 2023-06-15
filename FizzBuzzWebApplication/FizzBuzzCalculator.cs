using Microsoft.AspNetCore.Http;

namespace FizzBuzzWebApplication
{
    public class FizzBuzzCalculator
    {
        public string CalculateFizzBuzz(string value)
        {
            string result = string.Empty;
            if (!int.TryParse(value, out int num))
            {
                
                result = "Invalid Item";

            }
            if (num != 0)
            { 
                if (num % 3 == 0)
            {
                result += "Fizz";
            }

            if (num % 5 == 0)
            {
                result += "Buzz"; 
            }
            }
            return result;
        }

        private void LogDivision(int value, int divisor)
        {
            Console.WriteLine($"Divided {value} by {divisor}");
        }
    }

}
