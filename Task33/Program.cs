// Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
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
bool FindNumber(int[] array, int findNum)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findNum)
            result = true;
    }
    return result;
}
Console.Write("Введите искомое число: ");
int findNum = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(10, 0, 10);
PrintArray(arr);
bool find = FindNumber(arr, findNum);
Console.WriteLine(find? " -> Да": " -> Нет");