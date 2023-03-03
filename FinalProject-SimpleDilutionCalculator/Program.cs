using System;
using System.Collections.Generic;
namespace FinalProject_SimpleDilutionCalculator;

class Program
{ 
    static void Main(string[] args)
    {

        Console.WriteLine($"Enter 1 to calcuate the volume of diluent - enter 'exit' to leave the program");

       var input = Console.ReadLine();
        // Feature 1:"Master loop" 
        // Need to add ToUpper. How to do that with variable not string?
        

        do
        {
            Console.WriteLine("Enter the initial concentration of stock solution and its units");
            double initialConcentration = double.Parse(Console.ReadLine());
            //string initialConcentrationUnit = Console.ReadLine();

            Console.WriteLine("Enter the initial volume of the stock solution and its units");
            double initalVolume = double.Parse(Console.ReadLine());
            //string initialVolumeUnit = Console.ReadLine();

            Console.WriteLine("Enter the desired final concentration of the solution and its units");
            double finalConcentration = double.Parse(Console.ReadLine());
            //string finalConcentrationUnit = Console.ReadLine();

            //not recognizing values from DilutionCalculator. Possibly has something to do with the initialVolume in Dilution Calculator.

            DilutionCalculator dilutionCalculator = new DilutionCalculator(initialConcentration, initalVolume, finalConcentration);

            double result = dilutionCalculator.DiluentVolume;

            Console.WriteLine("The final volume of diluent needed to achieve the final concentration is: " + result + "mL");

            Console.WriteLine($"Enter 1 to calculate the volume of a diluent or enter 'exit' to exit to leave the program");
            input = Console.ReadLine();

            break;

        } while (input != "exit");
    }

}