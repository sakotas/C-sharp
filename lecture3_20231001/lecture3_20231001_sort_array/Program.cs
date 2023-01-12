// сортировка методом выбора
using static System.Console;
Clear();

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}  

void SelectionSort(int[] array)
{
    for(int i =0; i < array.Length-1; i++)
        {
        int MinPosition=i;
        
        for(int j = i+1; j < array.Length; j++)
        {
             if (array[j]<array[MinPosition])   MinPosition = j;

        }
        int temporary = array[i];
        array[i]=array[MinPosition];
        array[MinPosition]= temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);