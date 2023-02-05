/*Задача 49. Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
1 4 7 2         1 4 49 2
5 9 2 3         5 9 2  3
8 4 2 4         64 4 4 4*/
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

void SquareOfElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        
        matrix[i, j] *= matrix[i, j];      
    }
}

int[,] array2D = CreateMatrixRnd(3, 4, 1, 10);
PrintMatrix(array2D);
//int[,] squareOfElements = SquareOfElements(array2D);
Console.WriteLine($"{'|',10}");
Console.WriteLine($"{'V',10}");
SquareOfElements(array2D);
PrintMatrix(array2D);