// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillArray(int[,] matrix, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(start, end);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeEvenInd(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matr1[i, j] = matr1[i, j] * matr1[i, j];
        }
    }
}

Console.WriteLine("Введите количество строк n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов k");
int k = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[n, k];
FillArray(matrix, 1, 11);
PrintArray(matrix);
Console.WriteLine();

ChangeEvenInd(matrix);
PrintArray(matrix);
