// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min; //множитель
        array[i] = Math.Round(num, 1, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double FindMaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double FindMinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}

double DifferenceMinMax(double min, double max)
{
    double difference = Math.Round(max - min, 1, MidpointRounding.ToZero);
    return difference;
}

double[] arr = CreateArrayRndDouble(10, 0, 100);
PrintArray(arr);
double maxNum = FindMaxElement(arr);
double minNum = FindMinElement(arr);
double diff = DifferenceMinMax(minNum, maxNum);
Console.Write(" -> ");
Console.Write(diff);