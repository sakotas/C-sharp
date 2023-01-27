namespace MyLibArray;
using static System.Console;

public class MultidimensionalArray
{
    ///<summary>
    /// generate random filled double array with (size = unsigned int size M and N (array[m,n]),  begin of array,  end of array)
    /// check for size to be more than 0. in case of false - terminate the programm
    ///</summary>
    public static double[,] GenerateDoubleMNArray(uint sizeM, uint sizeN, double BeginArr, double EndArr)
    {
        if (sizeM == 0 || sizeN == 0)
        {
            WriteLine("Size can't be zero. Now terminate all progr");
            Environment.Exit(0);
        }

        double[,] result = new double[sizeM, sizeN];
        Random rnd = new Random();
        for (int i = 0; i < sizeM; i++)
        {
            for (int j = 0; j < sizeN; j++)
            {
                result[i, j] = BeginArr + rnd.NextDouble() * (EndArr - BeginArr);
            }
        }
        return result;
    }


    ///<summary>
    /// generate random filled double array with (size = unsigned int size M and N (array[m,n]),  begin of array,  end of array, int accuracy)
    /// Accuracy = number of digits, after dot (0.xxx)
    /// check for size to be more than 0. in case of false - terminate the programm
    ///</summary>
    public static double[,] GenerateDoubleMNArray(uint sizeM, uint sizeN, double BeginArr, double EndArr, int accuracy)
    {
        if (sizeM == 0 || sizeN == 0)
        {
            WriteLine("Size can't be zero. Now terminate all progr");
            Environment.Exit(0);
        }

        double[,] result = new double[sizeM, sizeN];
        Random rnd = new Random();
        for (int i = 0; i < sizeM; i++)
        {
            for (int j = 0; j < sizeN; j++)
            {
                result[i, j] = Math.Round((BeginArr + rnd.NextDouble() * (EndArr - BeginArr)), accuracy);
            }
        }
        return result;
    }

    ///<summary>
    /// print double[,] array.
    /// 
    ///</summary>

    public static void PrintDoubleMNArray(double[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($" {inArray[i, j]}");
                //Write($" {string.Format("{0:f4}", inArray[i,j])}"); 
            }
            WriteLine();
        }
    }



}


public class IntMultiDimentionalArray
{
    ///<summary>
    /// generate random filled INT array with (size = unsigned int size M and N (array[m,n]),  begin of array,  end of array)
    /// check for size to be more than 0. in case of false - terminate the programm
    ///</summary>
    public static int[,] GenerateIntMNArray(uint sizeM, uint sizeN, int BeginArr, int EndArr)
    {
        if (sizeM == 0 || sizeN == 0)
        {
            WriteLine("Size can't be zero. Now terminate all progr");
            Environment.Exit(0);
        }

        int[,] result = new int[sizeM, sizeN];
        Random rnd = new Random();
        for (int i = 0; i < sizeM; i++)
        {
            for (int j = 0; j < sizeN; j++)
            {
                result[i, j] = rnd.Next(BeginArr, EndArr + 1);
            }
        }
        return result;
    }

    ///<summary>
    /// print int[,] array.
    /// 
    ///</summary>
    public static void PrintIntMNArray(int[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($" {inArray[i, j]}");
                //Write($" {string.Format("{0:f4}", inArray[i,j])}"); 
            }
            WriteLine();
        }
    }


}


