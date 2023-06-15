using FizzBuzzWebApplication;

namespace FizzBuzzCalculatorTests
{
    [TestClass]
    public class FizzBuzzCalculatorTests
    {
        [TestMethod]
        public void CalculateFizzBuzz_InputIsMultipleOf3_ReturnsFizz()
        {
            // Arrange
            string value = "23";
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();

            // Act
            string result = calculator.CalculateFizzBuzz(value);

            // Assert
            Assert.AreNotEqual("Fizz", result);
        }
        [TestMethod]
        public void CalculateFizzBuzz_InputIsMultipleOf4_ReturnsFizz()
        {
            // Arrange
            string value = "9";
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
            string value = "11";
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();

            // Act
            string result = calculator.CalculateFizzBuzz(value);

            // Assert
            Assert.AreNotEqual("Buzz", result);

        }
        [TestMethod]
        public void CalculateFizzBuzz_InputIsMultipleOf6_ReturnsBuzz()
        {
            // Arrange
            string value = "5";
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();

            // Act
            string result = calculator.CalculateFizzBuzz(value);

            // Assert
            Assert.AreEqual("Buzz", result);

        }
        [TestMethod]
        public void CalculateFizzBuzz_InputIsMultipleOf7_ReturnsBuzz()
        {
            // Arrange
            string value = "15";
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();

            // Act
            string result = calculator.CalculateFizzBuzz(value);

            // Assert
            Assert.AreEqual("FizzBuzz", result);

        }
        public void CalculateFizzBuzz_InputIsMultipleOf9_ReturnsBuzz()
        {
            // Arrange
            string value = "17";
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();

            // Act
            string result = calculator.CalculateFizzBuzz(value);

            // Assert
            Assert.AreNotEqual("FizzBuzz", result);

        }
    }
}