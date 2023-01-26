namespace MyLib;
using static System.Console;
public class MyMetods
{
    ///<summary>
    /// Metod1 - // generate random filled int array wit size = size
    ///</summary>
    public static int[] GetLineArray(int size)  
    {
        int[] result = new int[size];
        for(int i =0; i< size; i++)
        {
            result[i] = new Random().Next();
        }
        return result;
    }

    ///<summary>
    /// Metod2 // generate random(from 0 to maxValue) filled int array wit size = size
    ///</summary>
    public static int[] GetLineArray(int size, int maxValue)
    {
        int[] result = new int[size];
        for(int i =0; i< size; i++)
        {
            result[i] = new Random().Next(maxValue+1);
        }
        return result;
    }


    ///<summary> 
    /// Metod3 // generate random(from minValue to maxValue) filled int array with size = size, 
    ///</summary>
    public static int[] GetLineArray(int size, int minValue, int maxValue) 
    {
        int[] result = new int[size];
        for(int i =0; i< size; i++)
        {
            result[i] = new Random().Next(minValue, maxValue+1);
        }
        return result;
    }

    
    ///<summary> 
    /// print usual array
    ///</summary>
    public static void PrintArray(int[] inArray)
    {


    }



}
