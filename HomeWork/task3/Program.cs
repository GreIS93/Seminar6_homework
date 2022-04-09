// Показать двумерный массив размером m×n заполненный целыми числами

void FillArray(int[,] matrix, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(start, end);
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

Console.WriteLine("Введите количество строк m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
int [,] matrix = new int[m, n];
FillArray(matrix, 10, 100);
PrintArray(matrix);