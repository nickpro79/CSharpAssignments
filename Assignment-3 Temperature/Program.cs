namespace Assignment_3_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();

                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    break;
                }

                double temperature = GetTemperature("Enter the current temperature:");

                switch (choice)
                {
                    case "1":
                        double celsius = ConvertFtoC(temperature);
                        Console.WriteLine($"The temperature in Celsius is: {celsius:F2} °C");
                        break;
                    case "2":
                        double fahrenheit = ConvertCtoF(temperature);
                        Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit:F2} °F");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("Select a choice for conversion:");
            Console.WriteLine("1. Convert to Celsius");
            Console.WriteLine("2. Convert to Fahrenheit");
            Console.WriteLine("3. Exit");
        }

        static double GetTemperature(string prompt)
        {
            Console.WriteLine(prompt);
            double temperature;
            while (!double.TryParse(Console.ReadLine(), out temperature))
            {
                Console.WriteLine("Invalid input. Please enter a valid temperature:");
            }
            return temperature;
        }
        static double ConvertFtoC(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static double ConvertCtoF(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
