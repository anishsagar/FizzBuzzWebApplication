namespace FizzBuzzWebApplication
{
    public class FizzBuzzCalculator
    {
        public string CalculateFizzBuzz(int value)
        {
            string result = string.Empty;

            if (value % 3 == 0)
            {
                result += "Fizz";
                LogDivision(value, 3);
            }

            if (value % 5 == 0)
            {
                result += "Buzz";
                LogDivision(value, 5);
            }

            if (string.IsNullOrEmpty(result))
            {
                result = "Invalid Item";
            }

            return result;
        }

        private void LogDivision(int value, int divisor)
        {
            Console.WriteLine($"Divided {value} by {divisor}");
        }
    }

}
