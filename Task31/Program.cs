// Задача 31. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
int[] CreateArrayRndInt(int sizeArray, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int sumNegativeNumbers(int[] array)
{
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sumNegative = sumNegative + array[i];
    }
    return sumNegative;
}
int sumPositiveNumbers(int[] array)
{
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPositive = sumPositive + array[i];
    }
    return sumPositive;
}
int[] GetSumNegativePositiveElem(int[] array)
{
    int sumNegative = 0;
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
        else sumPositive += array[i];
    }
    return new int[]{sumNegative, sumPositive};
}


int[] arr = CreateArrayRndInt(12, -9, 9);
int[] sumNegativePositiveElem = GetSumNegativePositiveElem(arr);
PrintArray(arr);
int sumNegativeNum = sumNegativeNumbers(arr);
int sumPositiveNum = sumPositiveNumbers(arr);
//Console.WriteLine($"Сумма всех отрицательных числе равна {sumNegativeNum}.");
//Console.WriteLine($"Сумма всех положительных числе равна {sumPositiveNum}.");
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных числе равна {sumNegativePositiveElem[0]}");
Console.WriteLine($"Сумма положительных числе равна {sumNegativePositiveElem[1]}");
//PrintArray(sumNegativePositiveElem);