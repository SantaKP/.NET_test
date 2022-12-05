using System.Text.RegularExpressions;

class PhoneNumberTask
{

    static void Main(string[] args)
    {

        Console.WriteLine("Enter your phone number");
        string phonenumb = Console.ReadLine();
        bool match = Regex.Match(phonenumb, @"^\d{4}[-\s]\d{4}$").Success;

        if (match)
        {
            Console.WriteLine("Thank you!");
        }
        else
        {
            Console.WriteLine("Phone number not valid. Please try again!");
        }


        Console.WriteLine("Enter your phone number with country code: ");
        string phonenumb2 = Console.ReadLine();
        bool match2 = Regex.Match(phonenumb2, @"^[+][3-3][7-7][1-1][-\s]\d{4}[-\s]\d{4}$").Success;

        if (match2)
        {
            Console.WriteLine("Thank you!");
        }
        else
        {
            Console.WriteLine("Phone number not valid. Please try again!");
        }





    }







}