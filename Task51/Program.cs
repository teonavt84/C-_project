/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/
int[,] CreateMatrixRnd(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} | ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("]");
    }
}

int SumElements(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0);
    if(matrix.GetLength(0) > matrix.GetLength(1))
        size = matrix.GetLength(1);
    for (int i = 0; i < size; i++)
          sum += matrix[i, i];
    return sum;
}

int[,] array2D = CreateMatrixRnd(5, 5, 1, 10);
PrintMatrix(array2D);
int sum = SumElements(array2D);
Console.WriteLine($"Сумма элементов главной диагонали равна {sum}");