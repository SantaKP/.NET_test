using OOP_introduction;

class People
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Enter First Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Last Name : ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter date format (ex. dd-mm-yyyy))");
        string dateFormat = Console.ReadLine();

        Console.WriteLine("Enter date of birth:");
        string dateStr = Console.ReadLine();

        Date date = Date.ConvertStringToDate(dateStr, dateFormat);
        PersonInfo person = new PersonInfo(name, lastName, date);
        person.Show();


    }
}


//class Person
//{
//   public class Date { 
//    private int day, month, year;

    
//    public int Day

//    {
        
//        get { return this. day; }
//        set 
//        { if (value < 0 || value > 31)
//            Console.WriteLine("Day entered is not correct");            
//              else  this.day = value; 
//        }
//    }
    
//    public int Month 
//    { 
//    get { return this.month; }
//        set
//        {
//            if (value < 0 || value > 12)
//                Console.WriteLine("Moth entered is not correct");
//            else this.month = value; }
//    }
//     public int Year
//    {
//        get { return this.year; }
//        set {
//            if (value < 1920 || value > 2022)
//            Console.WriteLine("Year entered is not correct");
//            else this.year = value; }
//    }

//    public void SetDate(string dateStr, string format)
//    {
       
//        string[] formatSplit = format.Split("-");
//        string[] dateSplit = dateStr.Split("-");

//        if (formatSplit[0] == "dd")
//        {
//            this.Day = Convert.ToInt32(dateSplit[0]);
//        }
//        else if (formatSplit[0] == "mm")
//        {
//            this.Month = Convert.ToInt32(dateSplit[0]);
//        }
//        else if (formatSplit[0] == "yyyy")
//        {
//            this.Year = Convert.ToInt32(dateSplit[0]);
//        }
//        else
//        {
//            Console.WriteLine("Wrong date format");
//            return;
//        }

//        if (formatSplit[1] == "dd")
//        {
//            this.Day = Convert.ToInt32(dateSplit[1]);
//        }
//        else if (formatSplit[1] == "mm")
//        {
//            this.Month = Convert.ToInt32(dateSplit[1]);
//        }
//        else if (formatSplit[1] == "yyyy")
//        {
//            this.Year = Convert.ToInt32(dateSplit[1]);
//        }
//        else
//        {
//            Console.WriteLine("Wrong date format");
//            return;
//        }

//        if (formatSplit[2] == "dd")
//        {
//            this.Day = Convert.ToInt32(dateSplit[2]);
//        }
//        else if (formatSplit[2] == "mm")
//        {
//            this.Month = Convert.ToInt32(dateSplit[2]);
//        }
//        else if (formatSplit[2] == "yyyy")
//        {
//            this.Year = Convert.ToInt32(dateSplit[2]);
//        }
//        else
//        {
//            Console.WriteLine("Wrong date format");
//            return;
//        }


//        public int GetAgeDifference(Date date)
//        {
//            int age = this.Year - date.Year;

//            if ((this.Month > date.Month) ||
//                (this.Month == date.Month && this.Day > date.Day))
//            {
//                age--;
//            }
//            return age;
//        }

//            public string GetString()
//            {
//                return this.Day + "-" + this.Month + "-" + this.Year;
//            }

//        }
   
//    private string firstName, lastname;
   

//    public string FirstName
//    { 
//        get { return this.FirstName; } 
//       set { this.FirstName = value; }
//    }
    
    

//        public string LastName 
//{
//    get { return this.LastName; }
//    set { this.LastName = value; }        
//}


//    public string FullName{

//        get { return this.FirstName + " " + this.LastName; }
//    }
    
//    public int Age { get { return this.Age; } }



    

//}
////class CalculateFullName
////{


////}

//class CalculateAge {

//    private int Age;
       
//}