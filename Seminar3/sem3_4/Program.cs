// Завод на заводе смена мастеров
// В смене всегда 3 человек
// 2 токаря 1 разряда 
// 1 токарь 4 разряда

// токарь 1 разряда x 
// 4 разряда в 2 раза больше чем эти вместе

// в конце смены токарь докладывает начальнику сколько они сделали 

// на вход количество деталей
// возможно ли? 
// Если возможно, то сколько сделали и сколько сделал каждый

using static System.Console;
Clear();

// int x = 1; // Количество сколько делает токарь 
// int sum = 6*x;

// кол-во деталей
// кол-во токарей 1 разряда
// кол-во токарей 2 разряда

Write("Сколько сделали деталей: ");
int partsTogether = int.Parse(ReadLine()!);
Write("Сколько токарей 1-го разряда: ");
int tokar1_qty = int.Parse(ReadLine()!);
Write("Сколько токарей 4-го разряда: ");
int tokar2_qty = int.Parse(ReadLine()!);

int tokar1_prod = 1;
int tokar2_prod = tokar1_prod * 4;
int production = tokar1_prod * tokar1_qty + tokar2_prod * tokar2_qty;

WriteLine($"Всего произвели {production}");

if (partsTogether % production == 0)
{
    WriteLine("Такое может быть!");
    int tokar1 = partsTogether / production;
    int tokar2 = tokar1 * 4;
    WriteLine($"Токарь первого разряда делает {tokar1}, а двое за смену: {tokar1 * 2}");
    WriteLine($"Токарь первого разряда делает {tokar2}");
    WriteLine($"Всего за смену произвели {production}");
}
else
{
    WriteLine("Какая-то из черепашек пиздит");
}