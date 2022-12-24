// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/* нет ограничения на N поэтому рассматриваем и для N отрицательного*/
/*делаем вывод в таблицу*/

using static System.Console;
Clear();

int CurPosX = 0;
int CurPosY = 0;
int TempNum = 0;
int Len = 0;

WriteLine("make numbers from 1 to N to the third power.");
Write("input N:");
if (!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Error. Input number, not string");
    return;
}
if (N > 0)
{
    int index = 1;
    while (index <= N)
    {
        //Write($"{Math.Pow(index, 3)} ");
        // тут было б удобнее функцие воспользоваться. Но т.к. не пользуемся - 2 раза код пишем в if  и в else
        // т.к. не пользуемся массивами, то вывод вручную придется таблицу рисовать.

        TempNum = (int)Math.Pow(index, 3); // определяем длинну Куба элемента (чтобы вписывался в табличу)
        Len = 0;
        while (TempNum > 0)
        {
            Len += 1;
            TempNum /= 10;
        }
        
        //WriteLine ("Len of curr index^3 = {0}", Len);
        
        // начинаем рисовать табличку
        (CurPosX, CurPosY) = GetCursorPosition();
        if ((CurPosX + Len + 5) >= Console.WindowWidth) // достигли края консоли - заканчиваем таблицу и переводим на следующую строку
        {
            // доделать Просто переводим
            SetCursorPosition(0, CurPosY + 7);
            (CurPosX, CurPosY) = GetCursorPosition();
        }
        
        //рисуем столбец таблицы
        
            int index1 = 0;
            while (index1 < (Len + 2))
            {
                Write("*");
                index1 += 1;
            }

            SetCursorPosition(CurPosX, CurPosY + 1);
            Write("{0}", index);
            SetCursorPosition(CurPosX + Len, CurPosY + 1);
            Write("|");
            SetCursorPosition(CurPosX, CurPosY + 2);
            
            index1 = 0;
            while (index1 < (Len + 2))
            {
                Write("*");
                index1 += 1;
            }
            SetCursorPosition(CurPosX, CurPosY + 3);

            Write("{0}|", (int)Math.Pow(index, 3));
            SetCursorPosition(CurPosX + Len + 2, CurPosY);

            SetCursorPosition(CurPosX, CurPosY + 4);
            index1 = 0;
            while (index1 < (Len + 2))
            {
                Write("*");
                index1 += 1;
            }
            SetCursorPosition(CurPosX + Len + 2, CurPosY);

           
        
    index += 1;
    }
    SetCursorPosition(0, CurPosY + 6);



    //    WriteLine(" ");
}
else
{
    int index = 1;
    while (index >= N)
    {
        // т.к. не пользуемся функциями - то копируем весь большой код рисования сюда =)
        //Write($"{Math.Pow(index, 3)} ");
        // отсюда
        //Write($"{Math.Pow(index, 3)} ");
        // тут было б удобнее функцие воспользоваться. Но т.к. не пользуемся - 2 раза код пишем в if  и в else
        // т.к. не пользуемся массивами, то вывод вручную придется таблицу рисовать.

        TempNum = Math.Abs((int)Math.Pow(index, 3)); // определяем длинну Куба элемента (чтобы вписывался в табличу)
        Len = 0;
        while (TempNum > 0)
        {
            Len += 1;
            TempNum /= 10;
        }
        Len +=1;  // Одно отличие. для минуса доп. место надо
        //WriteLine ("Len of curr index^3 = {0}", Len);
        
        // начинаем рисовать табличку
        (CurPosX, CurPosY) = GetCursorPosition();
        if ((CurPosX + Len + 5) >= Console.WindowWidth) // достигли края консоли - заканчиваем таблицу и переводим на следующую строку
        {
            // доделать Просто переводим
            SetCursorPosition(0, CurPosY + 7);
            (CurPosX, CurPosY) = GetCursorPosition();
        }
        
        //рисуем столбец таблицы
        
            int index1 = 0;
            while (index1 < (Len + 2))
            {
                Write("*");
                index1 += 1;
            }

            SetCursorPosition(CurPosX, CurPosY + 1);
            Write("{0}", index);
            SetCursorPosition(CurPosX + Len, CurPosY + 1);
            Write("|");
            SetCursorPosition(CurPosX, CurPosY + 2);
            
            index1 = 0;
            while (index1 < (Len + 2))
            {
                Write("*");
                index1 += 1;
            }
            SetCursorPosition(CurPosX, CurPosY + 3);

            Write("{0}|", (int)Math.Pow(index, 3));
            SetCursorPosition(CurPosX + Len + 2, CurPosY);

            SetCursorPosition(CurPosX, CurPosY + 4);
            index1 = 0;
            while (index1 < (Len + 2))
            {
                Write("*");
                index1 += 1;
            }
            SetCursorPosition(CurPosX + Len + 2, CurPosY);

           
        
        index -= 1;
    }
    SetCursorPosition(0, CurPosY + 6);
    WriteLine(" ");
}



//WriteLine("Console width = , {0}",Console.WindowWidth);
//int a = 0;
//int b = 0;
//(a, b) = GetCursorPosition();
//WriteLine("a= {0}", a);
//WriteLine("b= {0}", b);
//Console.SetCursorPosition(x,y);