// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* Calculator */

Console.WriteLine("Type two numbers, one at a time, press enter after each one of them");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
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
        num1 = Convert.ToDouble(Console.ReadLine());
        num2 = Convert.ToDouble(Console.ReadLine());
        change = false;
        Console.WriteLine("What do you want to do?");
    }

    char choice = Convert.ToChar(Console.ReadLine());

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
            if(num2 != 0)
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Don't divide by 0!");
            }
            break;

        case '%':
            Console.WriteLine(num1 % num2);
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