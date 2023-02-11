/*Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/
int[,] FillMatrixRnd(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

void ReplacingFirstLineWithLastOne(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j]; //переменной присваивается значение нулевого элемента;
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j]; // нулевому элементу присваивается значение последнего элемента;
        matrix[matrix.GetLength(0) - 1, j] = temp; // последнему элементу присваивается значение переменной;

    }
}

int[,] mtr = FillMatrixRnd(2, 4, 1, 10);
PrintMatrixRnd(mtr);
ReplacingFirstLineWithLastOne(mtr);
Console.WriteLine();
PrintMatrixRnd(mtr);