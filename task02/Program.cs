
namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();
            char choise;
            int num;
            double sum;
            double avarage;
            int largeNumber;
            int smallNumber;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(new string('=', 60));
                Console.WriteLine("===         Welcome to the Number Manager         ===");
                Console.WriteLine(new string('=', 60));
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Choose an option from the menu below:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tP - Print numbers");
                Console.WriteLine("\tA - Add a number");
                Console.WriteLine("\tI - Search For a number");
                Console.WriteLine("\tM - Display mean of the numbers");
                Console.WriteLine("\tS - Display the smallest number");
                Console.WriteLine("\tL - Display the largest number");
                Console.WriteLine("\tC - Clear The List");
                Console.WriteLine("\tR - Sort The List");
                Console.WriteLine("\tN - Add Multiple Numbers");
                Console.WriteLine("\tD - Remove duplication");
                Console.WriteLine("\tQ - Quit");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(new string('-', 60));
                Console.ResetColor();

                Console.Write("Your choice: ");
                choise = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(new string('-', 60));
                Console.ResetColor();

                switch (choise)
                {
                    case 'P':
                        if (listOfNumbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The list is empty.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("=== Numbers in the list ===");
                            Console.ResetColor();
                            Console.WriteLine(new string('-', 30));
                            for (int i = 0; i < listOfNumbers.Count; i++)
                            {
                                Console.Write("[ ");
                                Console.Write($"{listOfNumbers[i]} ");
                                Console.Write("]");
                            }
                            Console.WriteLine();
                            Console.WriteLine(new string('-', 30));
                        }
                        break;

                    case 'A':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== Add Number ===");
                        Console.ResetColor();
                        Console.Write("Enter a number to add: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        bool flag = true;

                        for (int i = 0; i < listOfNumbers.Count; i++)
                            if (num == listOfNumbers[i])
                            {
                                flag = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"This number {num} is already in the list. Cannot duplicate!");
                                Console.ResetColor();
                                break;
                            }
                        if (flag)
                        {
                            listOfNumbers.Add(num);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Number added successfully.");
                            Console.ResetColor();
                        }
                        break;
                    case 'I':
                        if (listOfNumbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The list is empty.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Enter the Number ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(">");
                            Console.ResetColor();
                            int numberToSearch = Convert.ToInt32(Console.ReadLine());
                            bool found = false;
                            for (int i = 0; i < listOfNumbers.Count; i++)
                            {
                                if (listOfNumbers[i] == numberToSearch)
                                {
                                    Console.WriteLine($"Index of The number is {i} ");
                                    found = true;
                                }
                            }
                            if (!found)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Cant Find This number,want to add ?(Y/N)");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(">");
                                Console.ResetColor();
                                char theInput = Convert.ToChar(Console.ReadLine());
                                if (char.ToUpper(theInput) == 'Y')
                                {
                                    listOfNumbers.Add(numberToSearch);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Number added successfully.");
                                    Console.ResetColor();
                                }
                                else if (char.ToUpper(theInput) == 'N')
                                {
                                    Console.WriteLine("Thank You");
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("invalid input");
                                    Console.ResetColor();
                                }
                            }
                        }
                        break;
                    case 'M':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== Calculate Mean ===");
                        Console.ResetColor();
                        if (listOfNumbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Unable to calculate the mean - no data.");
                            Console.ResetColor();
                        }
                        else
                        {
                            sum = 0;
                            for (int i = 0; i < listOfNumbers.Count; i++)
                                sum += listOfNumbers[i];

                            avarage = sum / listOfNumbers.Count;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"The average is {avarage:F2}");
                            Console.ResetColor();
                        }
                        break;

                    case 'S':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== Smallest Number ===");
                        Console.ResetColor();
                        if (listOfNumbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The list is empty!");
                            Console.ResetColor();
                        }
                        else
                        {
                            smallNumber = listOfNumbers[0];
                            for (int i = 1; i < listOfNumbers.Count; i++)
                            {
                                if (listOfNumbers[i] < smallNumber)
                                    smallNumber = listOfNumbers[i];
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"The smallest number in the list is {smallNumber}");
                            Console.ResetColor();
                        }
                        break;

                    case 'L':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== Largest Number ===");
                        Console.ResetColor();
                        if (listOfNumbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The list is empty!");
                            Console.ResetColor();
                        }
                        else
                        {
                            largeNumber = listOfNumbers[0];
                            for (int i = 1; i < listOfNumbers.Count; i++)
                            {
                                if (listOfNumbers[i] > largeNumber)
                                    largeNumber = listOfNumbers[i];
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"The largest number in the list is {largeNumber}");
                            Console.ResetColor();
                        }
                        break;

                    case 'C':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== Clear The List ===");
                        Console.ResetColor();
                        Console.Write("Are you sure you want to clear the list? (Y/N): ");
                        char input = Convert.ToChar(Console.ReadLine());
                        if (char.ToUpper(input) == 'Y')
                        {
                            listOfNumbers = new List<int>();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The list has been cleared.");
                            Console.ResetColor();
                        }
                        else if (char.ToUpper(input) == 'N')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Thank You");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("invalid input");
                            Console.ResetColor();
                        }
                        break;
                    case 'N':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== Add Multiple Numbers ===");
                        Console.ResetColor();

                        Console.WriteLine("Please enter numbers separated by spaces:");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("> ");
                        Console.ResetColor();

                        string[] numbers = Console.ReadLine().Split(' ');

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            listOfNumbers.Add(Convert.ToInt32(numbers[i]));
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Numbers have been added successfully!");
                        Console.ResetColor();
                        break;
                    case 'R':
                        if (listOfNumbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The list is empty!");
                            Console.ResetColor();
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== Sort The List ===");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Sort order (A for Ascending, D for Descending): ");
                        Console.ResetColor();
                        char sort = Convert.ToChar(Console.ReadLine());
                        if (char.ToUpper(sort) == 'D')
                        {

                            for (int i = 0; i < listOfNumbers.Count - 1; i++)
                            {
                                for (int j = 0; j < listOfNumbers.Count - 1; j++)
                                {
                                    if (listOfNumbers[j] < listOfNumbers[j + 1])
                                    {
                                        int temp = listOfNumbers[j];
                                        listOfNumbers[j] = listOfNumbers[j + 1];
                                        listOfNumbers[j + 1] = temp;
                                    }
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("List sorted in descending order.");
                            Console.ResetColor();
                        }
                        else if (char.ToUpper(sort) == 'A')

                        {
                            for (int i = 0; i < listOfNumbers.Count - 1; i++)
                            {
                                for (int j = 0; j < listOfNumbers.Count - 1; j++)
                                {
                                    if (listOfNumbers[j] > listOfNumbers[j + 1])
                                    {

                                        int temp = listOfNumbers[j];
                                        listOfNumbers[j] = listOfNumbers[j + 1];
                                        listOfNumbers[j + 1] = temp;
                                    }
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("List sorted in ascending order.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid sort order.");
                            Console.ResetColor();
                        }
                        break;
                    case 'D':

                        if (listOfNumbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("The list is empty.");
                            Console.ResetColor();
                        }
                        else
                        {
                            //{1,5,6,1,7,9,6}
                            List<int> numberWithoutDublicate = new List<int>();

                            for (int i = 0; i < listOfNumbers.Count; i++)
                            {
                                bool isdup = false;
                                for (int k = 0; k < numberWithoutDublicate.Count; k++)
                                {
                                    if (listOfNumbers[i] == numberWithoutDublicate[k])
                                    {
                                        isdup = true;
                                        break;
                                    }
                                }
                                if (!isdup)
                                {
                                    numberWithoutDublicate.Add(listOfNumbers[i]);
                                }
                            }
                            listOfNumbers = numberWithoutDublicate;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== Duplicates have been successfully removed ===");
                        Console.ResetColor();
                        break;
                    case 'Q':
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Goodbye! Thank you for using the Number Manager.");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unknown selection, please try again.");
                        Console.ResetColor();
                        break;
                }

                if (choise != 'Q')
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(new string('-', 60));
                    Console.WriteLine("Press Enter to continue...");
                    Console.ResetColor();
                    Console.ReadLine();
                }

            } while (choise != 'Q');
        }
    }
}
