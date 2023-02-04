/*Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/
void PrintArray(int[] array)
{
    //Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    //Console.Write("]");
}

int[] AddNumToArray()
{
    Console.Write("Введите размер массива: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    if (sizeArray <= 0) Console.WriteLine("Размер массива должен быть больше 1.");
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        Console.Write($"Введите число для {i} индекса: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int NumberOfZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count+=1;
    }
    return count;
}
Console.Clear();
int[] numArray = AddNumToArray();
PrintArray(numArray);
int result = NumberOfZero(numArray);
Console.Write(" -> ");
Console.Write(result);