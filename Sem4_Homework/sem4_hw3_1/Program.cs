// Задача 29: Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

//////  метод, который сформирует массив указанного размера в диапазоне указанных чисел

// А тут дорабатываем задачку: заполняем символами от начального до конечного (по их ASCII кодам)


using static System.Console;
Clear();

WriteLine("Random array size Z. filled with letters (between 1st a ");

Write("input any integer number (array size): ");
if (!int.TryParse(ReadLine(), out int ArraySize))
{
    WriteLine("Error! Input int number, not string or float ");
    return -1;
}
if (ArraySize <=0)
{
    WriteLine("Array size can't be zero or below. Now exit");
    return -1;
}

Write("input lower range of Random (only first Latter will be read. It will be converted to ascii ): ");
string LowerRange = ReadLine()!;

Write("input upper range of Random: (only first Latter will be read. It will be converted to ascii )");
string UpperRange = ReadLine()!;


//WriteLine($"we got {LowerRange} and {UpperRange}");
int begin = LowerRange[0];
int end = UpperRange[0];

if (begin > end) (begin, end) = (end,begin);
//WriteLine($"ascii code is {begin} and {end}");
//WriteLine($"And back from ascii to char {Convert.ToChar(begin)} and {Convert.ToChar(end)}");

PrintArray(GenerateArray(ArraySize, begin, end));


return 1;

char[] GenerateArray(int size, int begin, int end)
 {
    char[] array = new char[size];
    //array[i] = new Random().Next(0,2)
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToChar(rnd.Next(begin, end+1));
    }
    return array;
 }

void PrintArray(char[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        Write ($" {arr[i]}");
    }
    WriteLine();
}
