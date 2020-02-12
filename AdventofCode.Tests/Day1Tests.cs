using AdventofCode.Day1;
using NUnit.Framework;

namespace AdventofCode.Tests
{
    public class Day1Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(12)]
        [TestCase(14)]
        public void CalculateCorrectAmountOfFuelForOneModule(int moduleWeight)
        {
            var expectedFuelRequired = 2;
            var calculatedFuelRequired = Program.CalculateRequiredFuel(moduleWeight);

            Assert.AreEqual(expectedFuelRequired, calculatedFuelRequired);
        }
    }
}