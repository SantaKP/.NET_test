class Advanced_calculator
{




    static void Main(String[] args)

    {

        Console.WriteLine("Enter your first number");
        string number1str = Console.ReadLine();
        Console.WriteLine("Enter your second number");
        string number2str = Console.ReadLine();
        int number1 = Int32.Parse(number1str);
        int number2 = Int32.Parse(number2str);
        Console.Write("Enter symbol(/,+,-,*):");
        string symbol = Console.ReadLine();
        switch (symbol)
        {
            case "+":
                int addition = number1 + number2;
                Console.WriteLine("Addition:" + addition);
                break;
            case "-":
                int substraction = number1 - number2;
                Console.WriteLine("Subtraction:" + substraction);
                break;
            case "*":
                int multiplication = number1 * number2;
                Console.WriteLine("Multiplication:" + multiplication);
                break;
            case "/":
                double division = number1 / number2;
                Console.WriteLine("Division:" + division);
                break;

        }




    }




}