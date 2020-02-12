using System;
using System.IO;

namespace AdventofCode.Day1
{
    public class Program
    {
        private const string filePath = "C:\\kw\\OneDrive - Kantar\\training\\adventofcode\\Day1\\";
        private const string fileName = "Day1.txt";
        public static void Main(string[] args)
        {
            var totalAmountOfFuelRequired = ReadFileAndSumValues();
            Console.WriteLine(totalAmountOfFuelRequired);
        }

        private static int ReadFileAndSumValues()
        {
            var totalAmountOfFuel = 0;

            try
            {
                using (StreamReader sr = new StreamReader(string.Concat(filePath, fileName)))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        try
                        {
                            var moduleMass = decimal.Parse(line);
                            totalAmountOfFuel += CalculateRequiredFuel(moduleMass);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"Unable to parse '{line}'");
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("File could not be read");
                Console.WriteLine(e.Message);
            }

            return totalAmountOfFuel;
        }

        public static int CalculateRequiredFuel(decimal moduleMass)
        {
            var requiredFuel = decimal.ToInt32(Math.Floor(moduleMass / 3) - 2);
            return requiredFuel;
        }
    }
}
