// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows/*i < matrix.GetLength(0)*/; i++) //0 rows
    {
        for (int j = 0; j < columns/*i < matrix.GetLength(1)*/; j++) //1 columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
}

int SumElementsMainDiagonal(int[,] matrix)
{
    int sum = default;
    int count = matrix.GetLength(0) > matrix.GetLength(1) ? 1 : 0;

    for (int i = 0; i < matrix.GetLength(count); i++)
    {
        sum += matrix[i, i];
    }
    return  sum;
}

int[,] array2d = CreateMatrixRndInt(4,5,1,9);

PrintMatrix(array2d);
System.Console.WriteLine();

SumElementsMainDiagonal(array2d);

int result = SumElementsMainDiagonal(array2d);
System.Console.WriteLine(result);