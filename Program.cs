namespace calculator_2;

class Program
{
    public static int Addtion(int a, int b)
    {
        return a + b;
    }

    public static int Subtraction(int a, int b)
    {
        return a - b;
    }

    public static int Multipication(int a, int b)
    {
        return a * b;
    }

    public static int Division(int a, int b)
    {
        return a / b;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an equation of the following: \nadd, \nsubtract, \nmultiplie,\ndivide: ");
        var input = Console.ReadLine();

        switch (input)
        {
            case "add":
                if (input == "add")
                {
                    Console.WriteLine("Enter the first number: ");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter the second number: ");
                    var num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The result is " + Addtion(num1, num2));
                }
                break;

            case "subtract":
                if (input == "subtract")
                {
                    Console.WriteLine("Enter the first number: ");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter the second number: ");
                    var num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The result is " + Subtraction(num1, num2));
                }
                break;

            case "multiplie":
                if (input == "multiplie")
                {
                    Console.WriteLine("Enter the first number: ");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter the second number: ");
                    var num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The result is " + Multipication(num1, num2));
                }
                break;

            case "divide":
                if (input == "divide")
                {
                    Console.WriteLine("Enter the first number: ");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    var num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The result is " + Division(num1, num2));
                }
                break;
            default:
                Console.WriteLine("Incorrect equasion");
                break;
        }
    }
}
