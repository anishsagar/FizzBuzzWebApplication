using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzWebApplication
{
    [TestClass]
    public class FizzBuzzCalculatorTests
    {
        [TestMethod]
        public void CalculateFizzBuzz_InputIsMultipleOf3_ReturnsFizz()
        {
            // Arrange
            int value = 9;
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();

            // Act
            string result = calculator.CalculateFizzBuzz(value);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_InputIsMultipleOf5_ReturnsBuzz()
        {
            // Arrange
            int value = 10;
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();

            // Act


        }
    }
}
