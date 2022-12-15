Console.Write("input your name: ");
string name = Console.ReadLine();

if (name.ToLower() == "vasya")
{
    Console.Write ("Hello, my dear ", name);
    Console.WriteLine(name);
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(name);
}