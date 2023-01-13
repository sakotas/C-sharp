// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

using static System.Console;
Clear();

//int[] ar = new int[8];

// for(int i = 0; i < ar.Length ; i++)
// {
//     ar[i] = int.Parse(ReadLine());
// }

//WriteLine(ar);

int[] array = new int[8];
InitBinaryArray(array);
PrintArray(array);



void InitBinaryArray(int[] array)
{
    //array[i] = new Random().Next(0,2)
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}


void PrintArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}


