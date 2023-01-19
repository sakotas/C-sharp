using static System.Console;
Clear();


 for (int i =0; i < 25; i++)
 {
     WriteLine($"{i}! = {factorial(i)}");
 }



double factorial(int f)
{   
    if (f == 1 || f ==0) return 1;
    else return f* factorial(f-1);
    
}
