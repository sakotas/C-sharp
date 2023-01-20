// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]


using static System.Console;
Clear();

Write("Input size of array");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize); // create

//string stringArray=string.Join(",", array);
WriteLine($"[{string.Join(",", array)}]");
ReverseArray2(array);  /// revers array. Changing inbound
WriteLine($"[{string.Join(",", array)}]");
int[] newArray = ReverseArray1(array); // reverse again. Creating new array
WriteLine($"[{string.Join(",", newArray)}]");

int [] GetArray (int size)
{
    int[] resultArray = new int[size];
    for(int i=0; i< size; i++)
    {
        resultArray[i]= new Random().Next(1,10);
    }

    return resultArray;
}

int[] ReverseArray1(int[] InnArray)
{
    int[] result = new int[InnArray.Length];
    for(int i=0; i < InnArray.Length; i++)
    {
        result[i] = InnArray[InnArray.Length - i -1];
    }
    return result;
}

void ReverseArray2(int[] InnArray)
{
    for(int i=0; i < InnArray.Length/2; i++)
    {
        int temp = InnArray[i];
        InnArray[i] =  InnArray[InnArray.Length - i -1];
        InnArray[InnArray.Length - i -1] = temp;

        
    }

}
