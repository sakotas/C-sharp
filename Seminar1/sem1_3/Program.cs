﻿// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//
//3 -> Среда
//5 ->  Пятница

using static System.Console;
Write("Input day of the week: ");
int day = int.Parse(ReadLine()!);

/*switch (day)
{
    case 1: WriteLine("Monday"); break;case 2: WriteLine("Tuesday"); break;
    case 3: WriteLine("Wednesday"); break;
    case 4: WriteLine("Thursday"); break;
    case 5: WriteLine("Friday"); break;
    case 6: WriteLine("Saturday"); break;
    case 7: WriteLine("Sunday"); break;
}

*/
if (day >= 0 && day <= 7)
{
    if (day == 1)
    {
        WriteLine("Monday");
    }
    if (day == 2)
    {
        WriteLine("Tuesday");
    }
    if (day == 3)
    {
        WriteLine("Wednesday");
    }
    if (day == 4)
    {
        WriteLine("Thursday");
    }
    if (day == 5)
    {
        WriteLine("Friday");
    }
    if (day == 6)
    {
        WriteLine("Saturday");
    }
    if (day == 7)
    {
        WriteLine("Sunday");
    }
}
else
{
    WriteLine("I don't Know the day!!!");
}
