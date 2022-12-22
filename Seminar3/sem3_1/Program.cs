// 17. На вход номер дня недели.
// На выход - название дня недели.
// и ошибки обработать

using static System.Console;
WriteLine("Input number of the day");

if (!int.TryParse(ReadLine(), out int DayOfTheWeek))
{
    WriteLine("Error. Input number, not string");
    return;
}

switch (DayOfTheWeek)
{
    case 1:
        {
            WriteLine("Today is monday");
            break;
        }
    case 2:
        {
            WriteLine("Today is tuesday");
            break;
        }
    case 3:
        {
            WriteLine("Today is wednesday");
            break;
        }
    case 4:
        {
            WriteLine("Today is thursday");
            break;
        }
    case 5:
        {
            WriteLine("Today is friday");
            break;
        }
    case 6:
        {
            WriteLine("Today is satturday");
            break;
        }
    case 7:
        {
            WriteLine("Today is sunday");
            break;
        }
    default:
        {
            WriteLine("Please input number between 1 and 7. (days of the week)");
            break;
        }

}