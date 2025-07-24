using System;

class UnitConverter
{
    static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Unit Converter");
            Console.WriteLine("Please select from one of the following options");
            Console.WriteLine("1. Miles to Kilometers");
            Console.WriteLine("2.Pounds to Kilograms");
            Console.WriteLine("3.Fahrenheit to Celsius");
            String input = Console.ReadLine();

            //Validate user input

            if (input == "1")
            {
                MilesToKilometers();
            }
            else if (input == "2")
            {
                PoundsToKilograms();
            }
            else if (input == "3")
            {
                FahrenheitToCelsius();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again");
            }
           
                         
        }


    }

    static void MilesToKilometers()
    {
        Console.WriteLine("Please enter the number of miles: ");
        double miles = double.Parse(Console.ReadLine());
        double kilometers = miles * 1.609344;
        Console.WriteLine("{0} miles is equal to {1} kilometers.", miles, kilometers);
    }

    static void PoundsToKilograms()
    {
        Console.WriteLine("Please enter the number of pounds: ");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds * 0.45359237;
        Console.WriteLine("{0} pounds is equal to {1} kilograms.", pounds, kilograms);
    }

    static void FahrenheitToCelsius()
    {
        Console.WriteLine("Please enter the temperature in Fahrenheit: ");
        double fTemp = double.Parse(Console.ReadLine());
        double cTemp = (fTemp - 32) * 5 / 9;
        Console.WriteLine("{0} degrees Fahrenheit is equal to {1} degrees Celsius.", fTemp, cTemp);
    }
}
