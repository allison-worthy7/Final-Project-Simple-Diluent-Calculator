using System;

namespace FinalProject_SimpleDilutionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dilution Calculator!");
            //Feature 1: "Masterloop"
            while (true)
            {
                Console.WriteLine("Enter the value for initial concentration of stock solution");
                double initialConcentration = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the units for the initial concentration (ex: ug/uL, mg/L, etc.");
                string initialConcentrationUnit = Console.ReadLine();

                Console.WriteLine("Enter the value for initial volume of the stock solution");
                double initialVolume = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the units for the initial volume (ex: uL, mL, or L");
                string initialVolumeUnit = Console.ReadLine();

                Console.WriteLine("Enter the desired final concentration of the solution:");
                double finalConcentration = double.Parse(Console.ReadLine());

                string finalConcentrationUnit = "mg/mL";

                DilutionCalculator dilutionCalc = new DilutionCalculator(initialConcentration, initialConcentrationUnit, initialVolume, initialVolumeUnit, finalConcentration, finalConcentrationUnit);

                double diluentVolumeInMl = dilutionCalc.DiluentVolume();

                Console.WriteLine($"The final volume of diluent needed to achieve the final concentration is: {diluentVolumeInMl} mL");

                Console.WriteLine("Thank you for using the Dilution Calculator! Enter 'exit' to leave the program");

                string input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
            }
        }
    }
}

