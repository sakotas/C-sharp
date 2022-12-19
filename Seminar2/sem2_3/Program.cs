// **Задача 12:** 
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

using static System.Console;
Clear();

int num1 = new Random().Next(10,100);
int num2 = new Random().Next(1,10);

WriteLine($"First number is {num1}");
WriteLine($"Second number is {num2}");

// if (num1%num2 == 0)
// {
//     WriteLine("Even");
// }
// else 
// {
//     WriteLine(value: "Odd");
// }

WriteLine(num1%num2==0?"Even":"Odd");
// WriteLine(new Random().Next(10,100)%new Random().Next(1,10) == 0?"Even":"Odd");