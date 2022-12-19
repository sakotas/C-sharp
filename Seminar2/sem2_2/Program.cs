/* **Задача 11:**

Напишите программу, которая выводит случайное трёхзначное число и удаляет 
вторую цифру этого числа.

456 -> 46

782 -> 72

918 -> 98
*/

using static System.Console;
Clear();
int number = new Random().Next(100, 1000);
WriteLine(number);

int sot = number / 100;
//int des = (number - sot*100) / 10;
int edin = number % 10;
Write(sot);
WriteLine(edin);

//Если не со строками, а собрать число
WriteLine(sot*10 + edin);



