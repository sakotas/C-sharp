/*9 Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.

78 -> 8

12-> 2

85 -> 8
*/
using static System.Console;
Clear();
int number=new Random().Next(10,100);
WriteLine(number);

// тернарная операция
WriteLine(number/10>number%10?number/10:number%10);

// без использования тернарной операции - тоже самое
if(number/10>number%10)
{
    WriteLine(number/10);
}
else
{
    WriteLine(number%10);
}
