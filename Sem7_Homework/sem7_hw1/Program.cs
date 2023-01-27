// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// we solve this task by using Libraries; - MyLibrary
using static System.Console;
using MyLibArray;
Clear();

WriteLine("Input 4-5 parameters separated by space: ");
WriteLine("M,N - size of array(int values!)");
WriteLine("Begin and end of Random values (double type) - use comma, not dot");
Write("Accuracy after dot. (in case of need only): ");

string[] parametersString = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);


if (parametersString.Length >5)
{
    WriteLine("Warning!!! Only 5 parameters read. other will be casted aside.");
}

if (parametersString.Length < 4)
{
    WriteLine("At least 4 parameters required!. Now exit!");
    Environment.Exit(0);
}
else
{
    uint sizeM = 0;
    uint sizeN=0;
    double BeginRand = 0;
    double EndRand =0;
    int Accuracy =0;

    sizeM = CheckIntInput(parametersString[0], "Only int value allowed! (sizeM) now exit!");
    sizeN = CheckIntInput(parametersString[1], "Only int value allowed! (sizeN) now exit!");
    BeginRand = CheckDoubleInput(parametersString[2], "Only double(or int) values allowed! (Begin rand) now exit!");
    EndRand = CheckDoubleInput(parametersString[3], "Only double(or int) values allowed!(End Rand) now exit!");
    
    if (parametersString.Length == 5)
    {
        Accuracy = Convert.ToInt32(CheckIntInput(parametersString[4], "Only int value allowed! (Accuracy) now exit!"));

        //if(Accuracy<0)
        //{
          //  WriteLine("Accuracy must not less than zero! now exit");
//            Environment.Exit(0);
        //}

    WriteLine();
    double[,] array = MyLibArray.MultidimensionalArray.GenerateDoubleMNArray(sizeM, sizeN, BeginRand, EndRand, Accuracy);
    MyLibArray.MultidimensionalArray.PrintDoubleMNArray(array);

    }
    else
    {
        double[,] array = MyLibArray.MultidimensionalArray.GenerateDoubleMNArray(sizeM, sizeN, BeginRand, EndRand);
        MyLibArray.MultidimensionalArray.PrintDoubleMNArray(array);
    }
}


/////////////// All methods Below this Line //////////////////
uint CheckIntInput(string inString, string errorMsg)
{
    if (!uint.TryParse(inString, out uint result))
    {
        WriteLine(errorMsg);
        Environment.Exit(0);
    }
    return result;
}

double CheckDoubleInput(string inString, string errorMsg)
{
    if (!double.TryParse(inString, out double result))
    {
        WriteLine(errorMsg);
        Environment.Exit(0);
    }
    return result;
}