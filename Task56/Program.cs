/*Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
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

void PrintMatrixRnd(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int[] SumElementsRowsMatrix(int[,] matrix)
{
    int sum = 0;
    int[] sumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        sumArray[i] = sum;
        sum = 0;
    }
    return sumArray;
}

int SumMin(int[] array)
{
    int i = 0;
    int min = array[0];
    int posMin = 0;
    while (i < array.Length)
    {
        if (array[i] < min)
        {
        min = array[i];
            posMin = i;
        i++;
        }
        else
        {
            i++;
        }
    }
    return posMin;
}

int[,] matrix = FillMatrixRnd(4, 6, 1, 10);
PrintMatrixRnd(matrix);
int[] sumArray = SumElementsRowsMatrix(matrix);
int result = SumMin(sumArray);
Console.WriteLine($"{result+1} строка с наименьшей суммой элементов");