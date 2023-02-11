/*Задача 57. Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.*/
int[,] FillMatrixRnd(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 10);
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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n] = matrix[i, j];
            n++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

















void FrequencyDictionary(int[] array)
{
    int i = 0;
    int count = 1;
    int num = array[0];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] == num)
            count++;
        else
        {
            Console.WriteLine($"Число {num} встречается {count} раз.");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {num} встречается {count} раз.");

}

int[,] matrix = FillMatrixRnd(4, 4, 1, 10);
PrintMatrixRnd(matrix);
int[] array = MatrixToArray(matrix);
PrintArray(array);
Array.Sort(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FrequencyDictionary(array);

