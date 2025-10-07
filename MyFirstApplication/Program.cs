class Program
{
    static void Main()
    {
        // Ask for the first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Ask for the second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Compare and display the result
        if (num1 > num2)
        {
            Console.WriteLine($"{num1} is greater than {num2}.");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"{num2} is greater than {num1}.");
        }
        else
        {
            Console.WriteLine("Both numbers are equal.");
        }

        // Keep console open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
