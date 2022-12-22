// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using static System.Console;
Write("Input number of the day: ");
if (!int.TryParse(ReadLine(), out int DayOfTheWeek))  // try to learn how to catch different mistakes. Am I did everything ok? Please give feed back =)
{
    WriteLine("You should input int value! Now catch the error!!!");   // Write the error instead of crash application
    return -1; //  catch the error - returning with error code -1;
}

if (DayOfTheWeek < 6 && DayOfTheWeek > 0)
{
    WriteLine("Today is weekday :( ");
    return 1;   // mean the day is weekday
}

if (DayOfTheWeek == 6 || DayOfTheWeek == 7)
{
    WriteLine("Today is weekend!!! =)");
    return 2;  // mean the day is weekend !!!
}

if (DayOfTheWeek < 1 || DayOfTheWeek > 7)
{
    WriteLine("You Should input number between 1 and 7. Catch the little error =)");
    return 0;
}

return 0;   //  Logical can't reach this string in any case. But compilatror swears without this string...

// Learning how to use catsh. Above variant is faster, than try -> catch.
// using static System.Console;
// Write("Input number of the day: ");
// try
//     {
//     int DayOfTheWeek = int.Parse(ReadLine()!);

//     if (DayOfTheWeek < 6 && DayOfTheWeek > 0)
//         {
//             WriteLine("Today is weekday :( ");
//             return 0;   // mean the day is weekday
//         }
//     if (DayOfTheWeek == 6 || DayOfTheWeek == 7)
//         {
//             WriteLine("Today is weekend!!! =)");
//             return 1;  // mean the day is weekend
//         }
//     if (DayOfTheWeek < 1 || DayOfTheWeek > 7)
//         {
//             WriteLine("You Should input number between 1 and 7. Catch the little error =)");
//             return -1;
//         }
//     return -1;
//     }
// catch
//     {
//         WriteLine ("You should input int value! Now catch the error!!!");   // Write the error instead of crash application
//         return -1;  // mean we cauth some error
//     }
