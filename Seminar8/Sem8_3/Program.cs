// **Задача 57:** Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

using static System.Console;
Clear();

Write("Input size of array (m,n), begin rand, end rand, separated by space: ");

string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] paramInt = new int[parameters.Length];
if (parameters.Length == 4)
{
    for (int i = 0; i< parameters.Length; i ++)
    {
        paramInt[i] = CheckInput(parameters[i]);
    }
}
else
{
    WriteLine("Exactly 4 parameters required! Now exit!");
    Environment.Exit(0);
}


int[,] array = MyLibArray.IntMultiDimentionalArray.GenerateIntMNArray(Convert.ToUInt32(paramInt[0]), Convert.ToUInt32(paramInt[1]), paramInt[2],paramInt[3]);
MyLibArray.IntMultiDimentionalArray.PrintIntMNArray(array);
WriteLine();

int[] dict = new int[paramInt[3] - paramInt[2]+1];


for (int k = 0; k < dict.Length; k++)
{   dict[k] = 0;
    for (int i = 0; i < array.GetLength(0); i ++ )
    {
        for(int j =0; j < array.GetLength(1); j ++)
        {
            if (array[i,j] == k + paramInt[2])
            {
                dict[k] ++;
            }

        }
    }
}

for (int k = 0; k < dict.Length; k++)
{
    WriteLine($"{k + paramInt[2]} we meet {dict[k]} times");
}

/// methods below
int CheckInput(string inString)
{
    if (! int.TryParse(inString, out int result))
    {
        WriteLine("only int values required");
        Environment.Exit(0);
    }
    return result;
}