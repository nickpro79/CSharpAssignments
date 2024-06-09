namespace Assignment_2_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                if (choice == "5")
                {
                    break;
                }

                int num1 = GetNumber("Enter First Number");
                int num2 = GetNumber("Enter Second Number");

                bool validOperation = true;
                int result;

                switch (choice)
                {
                    case "1":
                        result = add(num1, num2);
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = subtract(num1, num2);
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = multiply(num1, num2);
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero");
                            validOperation = false;
                        }
                        else
                        {
                            result = divide(num1, num2);
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        validOperation = false;
                        break;
                }
                if (validOperation)
                {
                    Console.WriteLine("Press any key to continue...");
                }
                else
                {
                    Console.WriteLine("Press any key to try again...");
                }

                Console.ReadKey();
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
        }

        static int GetNumber(string prompt)
        {
            Console.WriteLine(prompt);
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
            return number;
        }

        static int add(int a, int b) {
            return a + b;
        }

        static int subtract(int a, int b)
        {
            return a - b;
        }

        static int multiply(int a, int b)
        {
            return a * b;
        }

        static int divide(int a, int b)
        {
            return a/b;
        }
    }
}
