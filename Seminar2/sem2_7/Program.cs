﻿//   Два стрелка
//  На вход - сколько банок каждый стрелок сбил
//  /*
//  На выход - сколько всего банок было
//  */
//  В последнюю попали одновременно.

// Задача непонятно зачем =)

using static System.Console;

Write("Input first number: ");
int FirstNumber = int.Parse(ReadLine()!);
Write("Input second number: ");
int SecondNumber = int.Parse(ReadLine()!);

int Result = FirstNumber + SecondNumber - 1;
WriteLine(Result);



// Доп. Задача не на оценку - на разминкупа
// В шкатулке хранится разноцветный бисер (или бусины). Все бусины имеют одинаковую форму,
//  размер и вес. Бусины могут быть одного из N различных цветов. В шкатулке много бусин каждого цвета.


// Требуется определить минимальное число бусин, которые можно не глядя вытащить из шкатулки так,
//  чтобы среди них гарантированно были две бусины одного цвета.

// Сколько раз надо взять по 2 бусины, чтобы они гарантированно попались одинакового цвета