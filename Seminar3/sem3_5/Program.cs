// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

using static System.Console;
Clear();

Write("Введите координату Xa:");
int xa = int.Parse(ReadLine()!);
Write("Введите координату Ya:");
int ya = int.Parse(ReadLine()!);
Write("Введите координату Xb:");
int xb = int.Parse(ReadLine()!);
Write("Введите координату Yb:");
int yb = int.Parse(ReadLine()!);

int katet1 = xb - xa;
int katet2 = yb - ya;
int gipotenuza_sqr = katet1 * katet1 + katet2 * katet2;
double gipotenuza = Math.Sqrt(gipotenuza_sqr);

WriteLine($"Суммой является {xa + ya + xb + yb}. Катет 1: {katet1}, Катет 2: {katet2}");
WriteLine($"Суммой квадратов катетов является {gipotenuza_sqr}, а значит гипотенуза (расстояние от точки до точки) равняется {gipotenuza:f2}");