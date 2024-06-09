namespace Assignment_1_Odd_or_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a target number: ");
            int targetNumber = int.Parse(Console.ReadLine());

            Console.Write("Do you want to print odd or even numbers?(odd/even)");
            string choice = Console.ReadLine().ToLower();

            Console.WriteLine($"Printing {choice} numbers less than {targetNumber}");

            for (int i = (choice == "even" ? 0 : 1); i <= targetNumber; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
