using static System.Console;
Clear();

static string CountSheep(int n)
{
    int i = 1;
    string phrase = "";
    while (i <= n)
    {
        phrase = phrase + i + " sheep...";
        i++;
    }
    return phrase;
//    throw new NotImplementedException();
}

WriteLine(CountSheep(0));