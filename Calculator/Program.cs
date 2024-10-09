class Program
{
    static void Main()
    {
        double num1 = GetValidNumber("Enter first number: ");
        double num2 = GetValidNumber("Enter second number: ");
        bool change = false;

        Console.WriteLine(@"
    + - add
    - - subtract
    * - multiply
    / - divide
    % - modulo
    x - change numbers
    q - quit
What do you want to do?");

        while (true)
        {
            if (change)
            {
                num1 = GetValidNumber("Enter first number: ");
                num2 = GetValidNumber("Enter second number: ");
                change = false;
                Console.WriteLine("What do you want to do?");
            }

            char choice = Console.ReadKey().KeyChar;
            // bierze od razu jeden przycisk
            Console.WriteLine();

            switch (choice)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;

                case '-':
                    Console.WriteLine(num1 - num2);
                    break;

                case '*':
                    Console.WriteLine(num1 * num2);
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("Don't divide by 0!");
                    }
                    break;

                case '%':
                    if (num2 != 0)
                    {
                        Console.WriteLine(num1 % num2);
                    }
                    else
                    {
                        Console.WriteLine("Don't modulo by 0!");
                    }
                    break;

                case 'q':
                    Environment.Exit(0);
                    break;

                case 'x':
                    change = true;
                    break;

                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        }
    }

    static double GetValidNumber(string prompt)
    {
        double number;
        string input;

        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (double.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("This is not a valid number. Please try again.");
            }
        }
    }
}
