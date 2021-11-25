using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            // geen arrange want de methode in production is static

            var result= FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy3Only_ReturnFizz()
        {
            // geen arrange want de methode in production is static

            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy5Only_ReturnBuzz()
        {
            // geen arrange want de methode in production is static

            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleBy3And5_ReturnTheSameNumber()
        {
            // geen arrange want de methode in production is static

            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }

    }
}
