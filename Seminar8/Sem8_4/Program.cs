// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

using static System.Console;
Clear();

int[,] array = MyLibArray.IntMultiDimentionalArray.GenerateIntMNArray(4,4,1,10);
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array);

int minValue = array[0,0];
int minIndexI = 0;
int minIndexJ = 0;

for( int i =0; i < array.GetLength(0); i++)
{
    for( int j =0; j < array.GetLength(1); j++)
    {
        if (array[i,j] < minValue)
        {
            minValue = array[i,j];
            minIndexI = i;
            minIndexJ = j;
        }
    }
}
WriteLine($"min element = {minValue} [{minIndexI},{minIndexJ}]");

 int[,] AfterDelArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
 AfterDelArray = DelRowCol(array, minIndexI, minIndexJ);
 MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(AfterDelArray);


/////////////methods below /////////

int[,] DelRowCol(int[,] inArray, int iRow, int jCol)
{
    int[,] result = new int[inArray.GetLength(0)-1, inArray.GetLength(1)-1];

int AfterDelI = 0;
int AfterDelJ = 0;

WriteLine ($"We dell Row= {iRow}, Col = {jCol}");

    for (int i =0; i < inArray.GetLength(0)-1; i++)
    {
        for(int j = 0; j < inArray.GetLength(1)-1; j++)
        {
            if (j < jCol)
            {
                AfterDelJ  = j;
            }
            else
            {
                AfterDelJ = j+1;
            }
            
            if (i < iRow)
            {
                AfterDelI  = i;
            }
            else
            {
                AfterDelI = i+1;
            }

            result[i,j] = array[AfterDelI,AfterDelJ];
        }
    }

return result;   
}