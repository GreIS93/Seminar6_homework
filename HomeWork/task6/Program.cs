// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

Console.WriteLine("Введите количество строк m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов k");
int k = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[m, k];
FillArray(matrix, 1, 11);
PrintArray(matrix);
Console.WriteLine();

Console.WriteLine("Введите искомое число");
int n = int.Parse(Console.ReadLine());
bool FindNum(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            if (n == matr1[i,j]) return true;
        }
    }
    return false;
}

void PrintInd(int[,] matr2)
{
    Console.WriteLine("Число соответствует позициям:");
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            if (n == matr2[i,j]) Console.Write($"({i}, {j}) ");
        }
    }
    Console.WriteLine();
}

if (FindNum(matrix)) PrintInd(matrix);
else Console.WriteLine("Такого элемента нет");