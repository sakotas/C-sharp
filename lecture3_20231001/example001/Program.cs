using static System.Console;
Clear();

//type1
void Method1()
{
    WriteLine("Author is DMM");
}

//type2
void Method2(string msg)
{
    WriteLine(msg);
}

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        i +=1;
        WriteLine (msg);
    }
}

//type3
int Method3()
{
    return DateTime.Now.Year;
}

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i=0; i < count; i++)
    {
        result += text;
    }
    return result;
}

Method1();
Method2("some text here");
Method2(msg: "another text");
Method21("repeating text",2);
Method21(count: 3, msg: "repeat3");    //при именованном вызове возможно менять последовательность... а можно ли? и нужно ли?
WriteLine(Method3());
string res = Method4(4,"_x");
WriteLine(res);

for(int i=2; i <=10; i++)
{
    for(int j=2; j<=10; j++)
    {
        WriteLine($"{i}x{j}={i*j}");

    }
    WriteLine();
}