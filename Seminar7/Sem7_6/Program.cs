// шахматы 1я клетка черная

// 1) на вход кордината - ответ какого цвета  клетка

// 2) нормальная шахм доска. (abcd... 1234... a1, a2)

// не вносим в массив всю доску шахматную.
// Сделать красивл

using static System.Console;
Clear();

Write("Input coordinate of chess: ");


string parameters = ReadLine();
int par1 = parameters[0];
int par2 = parameters[1];

// string p1 = parameters[0].ToString();
// WriteLine($"text = {p1}");

//char letter = 'A';
//int LetterInt = letter;


WriteLine(par1);
WriteLine(par2);

if ((par1+par2)%2 == 0 )
{
    WriteLine("Chern");

}
else
{
    WriteLine("bel");
}


