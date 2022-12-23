// Задача 19
// В решении не использовать обращение к символу строки. Только математические методы работы с числами
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



/* Усложняем задачу - делаем общий случай а не частный из 5 элементов, чтобы не скучно было*/
/* Не ругайтесь, ежели что =) 
Понятное дело в реальной жизни если нет задачи - не делай. Но тут то мы учимся - это полезно. =) */

using static System.Console;
Clear();

Write("Checking if number is palindrome (from 0 to 18 446 744 073 709 551 615). Input the number: ");  // we use the length of unsigned long int (64bit)

if (!ulong.TryParse(ReadLine(), out ulong Number))
{
    WriteLine("Please input any number from 0 to 18 446 744 073 709 551 615. Not a natural number entered. Now Exit!!!");
    return;
}


// Check length of the number:  (so long because can't use arrays)
int Len = 0;
ulong TempNum = Number;
while (TempNum > 0)
{
    Len += 1;
    TempNum /= 10;
    //        WriteLine("TempNum is now: {0}, len = {1}", TempNum, Len);  // - debuging (Later I'll check how to debug using breakpoints)
}
//WriteLine($"Length of the number is {Len}");   //--  for debuging purposes;

if (Len <= 1)
{
    WriteLine("The number is palindrome");
    return;
}

bool FlagPolindrom = true;
ulong HighBit = 0;
ulong LowBit = 0;

while (Len >= 2)
{
    HighBit = Number / (ulong)(Math.Pow(10, (Len - 1)));
    LowBit = Number % 10;
    Number = Number - (ulong)(HighBit * Math.Pow(10, (Len - 1))); // Remove high bit    - If  we need save the number(not destroy it) for any case - we can add temp variable instead of number
    Number = Number / 10;  // Remove Lower bit. 
    Len -= 2;

    // string below is debuging string..... Later I'll check how to debug using breakpoints
    //    WriteLine("Current HighBit = {0}, LowBit={1}, FlagPolindrom={2}, number_left={3}, Curren Len={4}", HighBit, LowBit,FlagPolindrom, Number, Len);

    if (HighBit != LowBit)
    {
        FlagPolindrom = false;
        //Len = 0;
        break;
    }
}

if (FlagPolindrom)
{
    WriteLine("The number is palindrome");
}
else
{
    WriteLine("The number isn't palindrome");
}

//int FirstNumber = int.Parse(ReadLine()!);
