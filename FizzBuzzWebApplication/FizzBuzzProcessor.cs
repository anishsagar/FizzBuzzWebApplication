namespace FizzBuzzWebApplication
{
    public class FizzBuzzProcessor
    {
        private readonly FizzBuzzCalculator calculator;

        public FizzBuzzProcessor()
        {
            calculator = new FizzBuzzCalculator();
        }

        public string[] ProcessArrayValues(string[] values)
        {
            List<string> results = new List<string>();

            foreach (string  value in values)
            {
                string result = calculator.CalculateFizzBuzz(value);
                results.Add(result);
            }

            return results.ToArray();
        }
    }

}
