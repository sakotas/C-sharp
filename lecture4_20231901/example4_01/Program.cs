using static System.Console;
Clear();

string[,] table = new string[2, 5];
table[1, 2] = "word";



// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         WriteLine($"-{table[rows,columns]}-");
//     }

// }

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
WriteLine();
PrintArray(matrix);


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}

void FillArray(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0,10);
        }
    }
}
