
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal partial class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string user_choice = "";
        do
        {
            Console.WriteLine("Please enter your choice: \n  " +
                "  P - Print numbers\r\n " +
                "   A - Add a number\r\n  " +
                "  M - Display mean of the numbers\r\n   " +
                " S - Display the smallest number\r\n   " +
                " L - Display the largest number\r\n    Q - Quit\r\n");
            user_choice = Console.ReadLine().ToUpper();
            switch (user_choice)
            {
                case "P":
                    PrintNumbers(numbers);
                    break;
                case "A":
                    AddNumber(numbers);
                    break;
                case "M":
                    calculateMean(numbers);
                    break;
                case "S":
                    findSmallestNumber(numbers);
                    break;
                case "L":
                    findGreatestNumber(numbers);
                    break;
                case "Q":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }
        while (user_choice != "Q");





    }


    static void PrintNumbers(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("[] - the list is empty.");

        }
        else
        {
            Console.Write("Your number list is [");
            foreach (var item in numbers)
            {
                Console.Write(item);
            }
            Console.WriteLine("]");
        }
    }

    static void AddNumber(List<int> numbers)
    {
        Console.Write("Enter a number to add: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            numbers.Add(number);
            Console.WriteLine($"{number} are added.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    static void calculateMean(List<int> numbers)
    {
        double mean = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            mean += numbers[i];

        }
        Console.WriteLine("Mean = " + mean / numbers.Count);
    }

    static void findSmallestNumber(List<int> numbers)
    {

        int smallest_number = 0;

        for (int i = 0; i < numbers.Count - 1; i++)
        {

            if (numbers[i] < numbers[i + 1])
                smallest_number = numbers[i];
            else smallest_number = numbers[i + 1];
        }

        Console.WriteLine("Smallest number is " + smallest_number);
    }
    static void findGreatestNumber(List<int> numbers)
    {

        int greatest_number = 0;

        for (int i = 0; i < numbers.Count - 1; i++)
        {

            if (numbers[i] > numbers[i + 1])
                greatest_number = numbers[i];
            else greatest_number = numbers[i + 1];
        }
        Console.WriteLine("Greatest number is " + greatest_number);

    }

}