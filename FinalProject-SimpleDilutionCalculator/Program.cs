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
        //Need to add a way for units to be added and passed to Conversion Tool. Maybe just another Console.ReadLine.

        do
        {
            Console.WriteLine("Enter the initial concentration of stock solution in units of mass or moles per volume");
            double initialConcentration = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the initial volume of the stock solution in units of volume");
            double initalVolume = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the desired final concentration of the solution in units of mass or moles per volume");
            double finalConcentration = double.Parse(Console.ReadLine());

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