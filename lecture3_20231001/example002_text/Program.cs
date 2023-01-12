// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// — Я думаю, — сказал князь, улыбаясь, — что,
// ежели бы вас послали вместо нашего милого
// Винценгероде, вы бы взяли приступом согласие
// прусского короля. Вы так красноречивы. Вы
// дадите мне чаю?
using static System.Console;
Clear();
 
string InputText = "— Я думаю, — сказал князь, улыбаясь, — что, "
 + "ежели бы вас послали вместо нашего милого"
 + "Винценгероде, вы бы взяли приступом согласие"
 + "прусского короля. Вы так красноречивы. Вы"
 + "дадите мне чаю? ";


string Replace (string text, char OldValue, char NewValue)
{
    string result = string.Empty;
    int length = text.Length;
    for(int i =0; i <length; i++)
    {
        if(text[i] == OldValue) result += $"{NewValue}";
        //if(text[i] == OldValue) result += NewValue;
        else result += $"{text[i]}";
    }

    return result;
}

string NewText = InputText;
NewText=Replace (NewText, ' ', '|');
NewText=Replace (NewText, 'к', 'К');
NewText=Replace (NewText, 'C', 'с');

WriteLine(NewText);