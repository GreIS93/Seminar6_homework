// Задать двумерный массив следующим правилом: Amn = m+n
Console.WriteLine("Введите количество строк m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i+j+2;
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0);  i++)
    {
        for (int j = 0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);