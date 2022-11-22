class Calculator
{

    static void Main(string[] args)
    {

     Console.WriteLine("Enter your first number:");
        string number1str = Console.ReadLine();
        Console.WriteLine("Enter your second number:");
        string number2str = Console.ReadLine(); 
        int number1 = Int32.Parse(number1str);
        int number2 = Int32.Parse(number2str);
        int adittion = number1 + number2;
        Console.WriteLine ("adition " + adittion);  
        Console.WriteLine("Enter your first number:");
        string number1str = Console.ReadLine();
        Console.WriteLine("Enter your second number:");
        string number2str = Console.ReadLine();
        int number1 = Int32.Parse(number1str);
        int number2 = Int32.Parse(number2str);
        int substraction = number1 - number2;
        Console.WriteLine ("substraction " + substraction);
        Console.WriteLine("Enter your first number:");
        string number1str = Console.ReadLine();
        Console.WriteLine("Enter your second number:");
        string number2str = Console.ReadLine();
        int number1 = Int32.Parse(number1str);
        int number2 = Int32.Parse(number2str);
        int multiplication = number1 * number2;
        Console.WriteLine ("multiplication " + multiplication);
        Console.WriteLine("Enter your first number:");
        string number1str = Console.ReadLine();
        Console.WriteLine("Enter your second number:");
        string number2str = Console.ReadLine();
        int number1 = Int32.Parse(number1str);
        int number2 = Int32.Parse(number2str);
        int division = number1 / number2;
        Console.WriteLine ("division " + division); 





    }
}