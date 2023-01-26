using static System.Console;
using MyLib;

int[] array=MyMetods.GetLineArray(10);
WriteLine($"{string.Join(" ", array)}");

array=MyMetods.GetLineArray(10,10);
WriteLine($"{string.Join(" ", array)}");

array=MyMetods.GetLineArray(10,5,10);
WriteLine($"{string.Join(" ", array)}");