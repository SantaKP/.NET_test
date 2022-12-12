class People
{

    public static void Main(string[] args) {


        Date date = new Date();
        
         int day = date.Day;
       
        int month = date.Month;
       
        int year = date.Year;
       
       



       
 

        Name name = new Name();
        string FirstName = name.FirstName;

        string LastName = name.LastName;
      
    CalculateFullName name2 = new CalculateFullName();
        Console.WriteLine(FirstName + " " + LastName);



    }

}



class Date
{
   
    private int day, month, year;

    
    public int Day

    {
        
        get { return this. day; }
        set 
        { if (value < 0 || value > 31)
            Console.WriteLine("Day entered is not correct");            
              else  this.day = value; 
        }
    }
    
    public int Month 
    { 
    get { return this.month; }
        set
        {
            if (value < 0 || value > 12)
                Console.WriteLine("Moth entered is not correct");
            else this.month = value; }
    }
     public int Year
    {
        get { return this.year; }
        set {
            if (value < 1920 || value > 2022)
            Console.WriteLine("Year entered is not correct");
            else this.year = value; }
    }
   
    
}


class Name
{
    private string firstName, lastname;
   

    public string FirstName
    { 
        get { return this.FirstName; } 
       set { this.FirstName = value; }
    }
    
    

        public string LastName 
{
    get { return this.LastName; }
    set { this.LastName = value; }        
}


}

class CalculateFullName
{

    private string FullName;    

}

class CalculateAge {

    private int Age;
       
}