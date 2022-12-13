using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;



class AllArrayActions
{
    public static void Main(string[] args) 
    {
        int[] array = UserInput.ArrayInput();
        ActionsWithArray.NegativeNumbers(array);
        ActionsWithArray.UnevenElements(array);
        double average = ActionsWithArray.CalculateAverageValue(array);
        //ActionsWithArray.AverageValue(double average);
        ActionsWithArray.EachSecondElement(array);
        ActionsWithArray.AverageValue(average);
        ActionsWithArray.SmalerThenAverage(array, average);
       
    }


}





class UserInput
{

    public static int[] ArrayInput()
    {
        
        Console.WriteLine("Please enter the size of the array: ");
        int array = int.Parse(Console.ReadLine());
        int[] elements = new int[array];

        
        for (int i = 0; i < elements.Length; i++)
        {
            Console.WriteLine("Please enter " + i + " " + "element");
            int strElement = int.Parse(Console.ReadLine());
             elements[i] = strElement;
        }
        return elements;
      


    }
     
}



class ActionsWithArray
{


    public static void NegativeNumbers( int [] arr)
    {   
        foreach(int streElement in arr)
        if (streElement < 0)

        {
             Console.WriteLine("Negative numbers are: " + streElement); 

        }
    }
    


    //print out uneven elements

    public static void UnevenElements(int[] arr)
    {
        foreach (int strElement in arr)
            if (strElement % 2 == 1 || strElement % 2 == -1)
            {
                Console.Write("Numbers which are uneven: " + strElement);

                
            }

        Console.Write("\n");
    }




 //   Print out each second element.
    public static void EachSecondElement(int[] arr) {
        
            Console.Write("Each second element :");
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.Write(" " + arr[i]);
            }

        Console.Write("\n");
    }


    //  Compute average value of the array.
    

    public static double CalculateAverageValue(int[] arr)
    {
        double average = 0;
        foreach (int strElement in arr)
            average += strElement;

        average /= arr.Length;
        return average;
    }
public static void AverageValue(double average)
    {
        Console.Write("Average value : " + average + "\n");
       
    }

    //   Establish how many elements are smaller than average value
    public static void SmalerThenAverage(int[] arr,  double average)
    {
        foreach (int strElement in arr)
 if (strElement < average)
 Console.Write("Smaler then average: " + strElement);
           
               
        
    }
    
   
   
    
 //   Compute how many elements are odd (uneven).
public static void HowManyUnevenElements(int[] arr)
    {
        foreach (int strElement in arr)

            if (strElement % 2 == 1)///also need to include neg numbers
        {
            Console.Write("There is " + strElement + "uneven elements");
        }
        Console.Write("\n");
    }



//  Verify if there are multiple elements with the same value
    public static void SameValue(int[] arr) {
        foreach (int strElement in arr) 
        { } 

        

    }


}
























