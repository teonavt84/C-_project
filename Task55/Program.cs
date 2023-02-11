/*Задача 55. Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.*/
int[,] FillMatrixRnd(int rows, int columns, int min, int max)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] ReplacingRowsWithColumns(int[,] matrix)
{
    int[,] replaceMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            replaceMatrix[j, i] = matrix[i, j];
        }

    }
    return replaceMatrix;
}

Console.WriteLine("Введите размер двумерного массива: ");
Console.Write("Количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
if (row != column)
{
    Console.WriteLine("Невозможно заменить строки на столбцы");
    return;
}
int[,] matrix = FillMatrixRnd(row, column, 1, 100);
PrintMatrix(matrix);
Console.WriteLine();
int[,] mtr = ReplacingRowsWithColumns(matrix);
PrintMatrix(mtr);
