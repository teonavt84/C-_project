/*Задача 59. Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7*/
int[,] FillMatrixRnd(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrixRnd3D(int[,] matrix)
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

int[] IndexMinNumber(int[,] matrix)
{
    int minNum = matrix[0, 0];
    int[] result = new int[3];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minNum > matrix[i, j])
            {
                minNum = matrix[i, j];
                result[0] = minNum;
                result[1] = i;
                result[2] = j;
            }
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int[,] DelRow(int[,] array, int row)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1)];
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == row)
        {
            row = -1;
            continue;
        }

        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[x, j] = array[i, j];
        }
        x++;
    }
    return result;
}

int[,] DelCol(int[,] array, int col)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int x = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == col) continue;
            result[i, x] = array[i, j];
            x++;
        }
    }
    return result;
}

int[,] matrix = FillMatrixRnd(3, 4, 1, 10);
PrintMatrixRnd3D(matrix);
int[] num = IndexMinNumber(matrix);
PrintArray(num);
// int[,] newMtr = DelRowColumn(matrix, num);
int[,] matrixNoRow = DelRow(matrix, num[1]);
int[,] matrixNoCol = DelCol(matrixNoRow, num[2]);
Console.WriteLine();
PrintMatrixRnd3D(matrixNoCol);