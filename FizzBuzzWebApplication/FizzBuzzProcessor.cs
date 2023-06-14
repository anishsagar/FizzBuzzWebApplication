namespace FizzBuzzWebApplication
{
    public class FizzBuzzProcessor
    {
        private readonly FizzBuzzCalculator calculator;

        public FizzBuzzProcessor()
        {
            calculator = new FizzBuzzCalculator();
        }

        public string[] ProcessArrayValues(int[] values)
        {
            List<string> results = new List<string>();

            foreach (int value in values)
            {
                string result = calculator.CalculateFizzBuzz(value);
                results.Add(result);
            }

            return results.ToArray();
        }
    }

}
