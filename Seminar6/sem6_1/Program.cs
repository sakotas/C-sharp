using static System.Console;
Clear();
Write("Введите размер массива: ");

int arraySize=int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

WriteLine($"[{String.Join(",", array)}]");
ReverseArray2(array);
WriteLine($"[{String.Join(",", array)}]");
// WriteLine($"[{String.Join(",", ReverseArray1(array))}]");

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1,10);
    }
    return resultArray;
}

int[] ReverseArray1(int[] inArray)
{
    int[] resultArray = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        resultArray[i] = inArray[inArray.Length - 1 - i];
    }

    return resultArray;

}

void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = temp;
    }
}