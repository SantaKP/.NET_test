using Microsoft.VisualBasic;

class Zodiac_signs
{

    static void Main(String[] args)
    {

        int day, month;
        Console.WriteLine("Enter your day of birth:");
        day = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your month of birth");
        month= int.Parse(Console.ReadLine());
        Console.WriteLine("Your Zodiac sing is:");
        if (
            (day >= 21 && month == 1 || day <= 19 && month == 2)
            )
        Console.WriteLine("Aquarius");
        if (
            (day >= 20 && month == 2 || day <= 21 && month == 3)
            )
        Console.WriteLine("Piscies");
        if (
            (day >= 21 && month == 3 || day <= 19 && month == 4)
            )
        Console.WriteLine("Aries");
        if (
            (day >= 20 && month == 4 || day <= 20 && month == 5)
            )
        Console.WriteLine("Taurus");
        if (
            (day >= 21 && month == 5 || day <= 21 && month == 6)
            )
        Console.WriteLine("Gemini");
        if (
            (day >= 22 && month == 6 || day <= 22 && month == 7)
            )
        Console.WriteLine("Cancer");
        if (
            (day >= 23 && month == 7 || day <= 22 && month == 8)
            )
        Console.WriteLine("Leo");
        if (
            (day >= 23 && month == 8 || day <= 23 && month == 9)
            )
        Console.WriteLine("Virgo");
        if (
            (day >= 24 && month == 9 || day <= 23 && month == 10)
            )
        Console.WriteLine("Libra");
        if (
            (day >= 24 && month == 10 || day <= 22 && month == 11)
            )
        Console.WriteLine("Scorpio");
        if (
            (day >= 23 && month == 11 || day <= 21 && month == 12)
            )
        Console.WriteLine("Sagittarius");
        if (
            (day >= 22 && month == 12 || day <= 20 && month == 1)
            ) 
        Console.WriteLine("Capricorn");










    }







}