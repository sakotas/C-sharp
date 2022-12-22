// Доп. Задача не на оценку - на разминкупа
// В шкатулке хранится разноцветный бисер (или бусины). Все бусины имеют одинаковую форму,
//  размер и вес. Бусины могут быть одного из N различных цветов. В шкатулке много бусин каждого цвета.


// Требуется определить минимальное число бусин, которые можно не глядя вытащить из шкатулки так,
//  чтобы среди них гарантированно были две бусины одного цвета.

// Сколько раз надо взять по 2 бусины, чтобы они гарантированно попались одинакового цвета

using static System.Console;
Clear();

Write("Input number of colors: ");
int Colors = int.Parse(ReadLine()!);
Write("Input number of beans: ");
int Total = int.Parse(ReadLine()!);

int min_beads =  Total - Colors + 2;
WriteLine("Min beads to take guaranteed have two colors = {0} ", min_beads);

//int min_pairs = -1;

// min_pairs = (min_beads % 2 == 0) ? (min_beads / 2) : (min_pairs = (min_beads / 2) + 1);
// WriteLine ("min pairs of beads to take to have gouranteed two colors: {0}", min_pairs);
// не так понял задание
// не решается оказывается =)