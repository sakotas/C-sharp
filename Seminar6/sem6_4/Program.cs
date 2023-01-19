using static System.Console;
Clear();

// 6 знаков билетик: сумма первых трех равна сумме трех последних
// На входе 6 число, на выходе проверка счастливый или нет

Write("Введите 6-ти значное число: ");
int n = int.Parse(ReadLine()!);

isLucky(n);

void isLucky(int number)
{
    int a = (number / 100000);
    int b = (number / 10000) % 10;
    int c = (number / 1000) % 10;
    int d = (number / 100) % 10;
    int e = (number / 10) % 10;
    int f = (number / 1) % 10;
    WriteLine($"a b c d e f");
    WriteLine($"{a} {b} {c} {d} {e} {f}");
    if(a + b + c == d + e + f) WriteLine("Счастливый билетик!");
    else WriteLine("Не счастливый билетик =(");
}