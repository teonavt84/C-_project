// Задача 30. Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// Console.WriteLine("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] CreateArray(int size, int minimal, int maximal)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(minimal, maximal);
        i++;
    }
    return array;
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{array[position]} ");
        position++;
    }
}
Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
Console.WriteLine("Минимальное: ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное: ");
int maxNum = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(sizeArray, minNum, maxNum);
PrintArray(arr);