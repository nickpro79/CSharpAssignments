namespace Assignment_4_Palindrome
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Palindrome Checker");

                string input = GetInput("Enter a value (or type 'exit' to quit):");

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                bool isPalindrome = CheckPalindrome(input);
                DisplayResult(input, isPalindrome);

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static bool CheckPalindrome(string input)
        {
            string normalizedInput = input.ToLower().Replace(" ", "");
            char[] charArray = normalizedInput.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);

            return normalizedInput == reversedInput;
        }

        static void DisplayResult(string input, bool isPalindrome)
        {
            if (isPalindrome)
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }
        }
    }
}
