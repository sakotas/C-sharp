// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//
//3 -> Среда
//5 ->  Пятница

using static System.Console;
Write ("Input day of the week: ");
int day = int.Parse(ReadLine()!);

switch (day)
{
    case 1: WriteLine("Monday"); break;
    case 2: WriteLine("Tuesday"); break;
    case 3: WriteLine("Wednesday"); break;
    case 4: WriteLine("Thursday"); break;
    case 5: WriteLine("Friday"); break;
    case 6: WriteLine("Saturday"); break;
    case 7: WriteLine("Sunday"); break;
}
