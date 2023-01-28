// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] CreateArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
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
int[] PairsOfNumbers(int[] array)
{
    int sizeArray = array.Length / 2;
    if (array.Length % 2 == 1) sizeArray += 1;
    int[] pairsArray = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        pairsArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) pairsArray[sizeArray - 1] = array[array.Length / 2];
    return pairsArray;
}
int[] arr = CreateArray(5, 1, 100);
PrintArray(arr);
int[] pairs = PairsOfNumbers(arr);
Console.Write(" -> ");
PrintArray(pairs);
