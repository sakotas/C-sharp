using static System.Console;
Clear();

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


Write("Введите размер массива, мин и макс через пробел: ");
string[] parametersArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parametersArray[0]), int.Parse(parametersArray[1]), int.Parse(parametersArray[2]));
WriteLine("=====Готов Массив=====");
PrintArray(array);
WriteLine();
WriteLine("======================");
WriteLine();

Write("Введите диапазон поиска через пробел: ");
string[] parametersRange = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int min = int.Parse(parametersRange[0]);
int max = int.Parse(parametersRange[1]);

Write($"Количество элементов в массиве в диапазоне от {min} до {max}: ");
WriteLine(findInRange(array));

int findInRange(int[] inArray)
{
    int result = 0;
    foreach (var a in inArray)
    {
        if(a >= min && a <= max)
        {
            result++;
        }
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;

}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}