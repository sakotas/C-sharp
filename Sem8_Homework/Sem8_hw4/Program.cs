// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();

int[] XX = new int[90];  // we have 90 diff 2digit numbers
for (int i = 0; i < 90; i++)
{
    XX[i] = i + 10;
}


// for (int i = 0; i < 100; i++)
// {
//     WriteLine($"{i} = {PickRandom(XX)}");
// }

// we take this size of 3 dimension array because we need having exactly 90 elements in it.
// otherwise we'll take(randomly) less than all numbers from 10 to 99. Or have nothing to put in it. (but according to task we need place 2digit numbers in it)
int[,,] array = new int[10, 3, 3];
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for(int k=0; k< 3; k++)
        {
            array[i,j,k] = PickRandom(XX);
            WriteLine($"{array[i,j,k]} ({i},{j},{k})");
        }
    }
}

// if we want to check that all numbers was picked
// WriteLine("numbers in array no picked = ");
// for (int i = 0; i < 90; i++)
// {
//     Write($" {XX[i]}");
// }


////// methods below/////

//we have array[90] values from 10 to 99.
// We need to pick randomly numbers and not to take any two times;
// We randomly select num from 0 to 90 - if it is empty we can take nearest to the left or to the right - it won't be less random
// (if we go every time to  the right - it'll be a little bit less randomly.)
// after taking the number - we reset it to zero - for not to taki it twice
int PickRandom(int[] inArray)
{
    int result = 0;
    Random rnd = new Random();
    int GoLeft = rnd.Next(0, 2);
    int index = rnd.Next(0, 91);  // start random serch from this element.

    int count = 0;  // if count == array's Length - than we looked through all the array once for sure. And 100% have no numbers left in it!
    while (count < inArray.Length)
    {
        if (inArray[index % 90] != 0)
        {
            //   WriteLine($"____________index = {index}");
            result = inArray[index % 90];
            inArray[index % 90] = 0;
            return result;
        }
        index = (GoLeft == 1)? (index + 1) : (index-1);  // 50% chance to go left or to go right. otherwise it'll be less random.
        index = (index ==-1)? 89: index;

        count++;
    }

    return -1;  // we looked through all the array once and found no numbers except zeros. (We took each number for one time for sure)
}
