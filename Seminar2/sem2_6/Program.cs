// Два стрелка
// На вход - сколько каждый стрелок сбил
// На выход - общее количество банок
// Всегда попадают в последнюю банку вместе

using static System.Console;
Clear();
WriteLine("Банок у стрелка 1: ");
int num1 = int.Parse(ReadLine()!);

WriteLine("Банок у стрелка 2: ");
int num2 = int.Parse(ReadLine()!);

WriteLine($"Банок всего = {num1 + num2 - 1}");