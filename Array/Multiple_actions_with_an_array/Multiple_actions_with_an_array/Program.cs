class Multiple_actions_with_an_array
{
    public static int EnterIntNumber()
    {
        int input = 0;
        Console.WriteLine("Enter the integer number : ");
        while (true)
        {
            try
            {
                input = Int32.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("The value provided is wrong. Try again");
            }
        }
        return input;
    }







}