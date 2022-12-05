using System.Collections.Specialized;
using System.Text.RegularExpressions;

class Array_Split
{


   

    static void Main(string[] args)
    
    {

        Console.WriteLine("Enter your phone number");
        string phonenumb = Console.ReadLine();
        bool match = Regex.Match(phonenumb, @"^[+][3-3][7-7][1-1][-\s]\d{4}[-\s]\d{4}$").Success;
        
        if (match) { Console.WriteLine("Thank you!");
        }
        else { Console.WriteLine("Phone number not valid. Please try again!");
        }

        //string nbr = "20, 30, 40, 44";
        //string[] arraySplit = nbr.Split(',');
        //foreach (string nbr2 in arraySplit)
        //Console.WriteLine(nbr2);
        //int[] arr = new int[arraySplit.Length];







        //Console.ReadLine();
        //string numberSplit = Console.ReadLine();
        //string[] numbers = numberSplit.Split(";");
        //foreach (string number in numbers)
        //Console.WriteLine(number);
        




}






    }




















































































