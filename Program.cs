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
        while (true)
        {
            Console.WriteLine("Enter an equation of the following: \na for: add, \ns for: subtract, \nm for: multiplie,\nd for: divide: ");
            var input = Console.ReadLine();
            Console.WriteLine("------------------------------------------------");
            if (input == "exit")
                break;


            switch (input)
            {
                case "a":
                    if (input == "a")
                    {
                        Console.WriteLine("Enter the first number: ");
                        var num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Enter the second number: ");
                        var num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("The result is " + Addtion(num1, num2));
                        Console.WriteLine("------------------------------------------------");
                    }
                    break;

                case "s":
                    if (input == "s")
                    {

                        Console.WriteLine("Enter the first number: ");
                        var num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Enter the second number: ");
                        var num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------");
                        if (num2 > num1)
                        {
                            Console.WriteLine("The result is " + Subtraction(num2, num1));
                        }
                        else
                            Console.WriteLine("The result is " + Subtraction(num1, num2));

                       Console.WriteLine("------------------------------------------------");
                    }
                    break;

                case "m":
                    if (input == "m")
                    {
                        Console.WriteLine("Enter the first number: ");
                        var num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Enter the second number: ");
                        var num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("The result is " + Multipication(num1, num2));

                        Console.WriteLine("------------------------------------------------");
                    }
                    break;

                case "d":
                    if (input == "d")
                    {
                        Console.WriteLine("Enter the first number: ");
                        var num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Enter the second number: ");
                        var num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------");
                        if (num2 > num1)
                        {
                            Console.WriteLine("The result is " + Division(num2, num1));
                        }
                        else
                            Console.WriteLine("The result is " + Division(num1, num2));

                       Console.WriteLine("------------------------------------------------");
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect letter please try again");
                    Console.WriteLine("------------------------------------------------");
                    break;
            }
        }

    }
}
