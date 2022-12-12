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
        ActionsWithArray.AverageValue(array);
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
             Console.WriteLine("Negative numbers are: " + streElement) ;


        }

       
    }



    //print out uneven elements

    public static void UnevenElements(int[] arr)
    {
        foreach (int strElement in arr)
            if (strElement % 2 == 1 || strElement % 2 == -1)///also need to include neg numbers
            {
                Console.WriteLine("Numbers which are uneven: " + strElement);
            }

       
    }


    //   Compute how many elements are odd (uneven).

    public static void HowManyUnevenElements(int[] arr)
    {
        foreach (int strElement in arr)

        if (strElement % 2 == 1)///also need to include neg numbers
        {
            
        }




    }



//  Verify if there are multiple elements with the same value
    public static void SameValue(int[] arr) {
        foreach (int strElement in arr) { } 

        

    }




 //   Print out each second element.
    public static void EachSecondElement(int[] arr) { 
    
    
    
    }


 //  Compute average value of the array.
    public static void AverageValue(int[] arr) {

        int valueOfArray = 

        Console.WriteLine("Average value is : " + arr);
    
    
    }


//   Establish how many elements are smaller than average value
    public static void SmalerThenAverage(int[] arr)
    {


    }
    
   
   
    


}
























