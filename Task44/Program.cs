﻿// Задача 44. Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int[] Fibonacci(int number)
{
    int[] fibo = new int[number];
    fibo[0] = 0;
    fibo[1] = 1;
    for (int i = 2; i < number; i++)
    {
        fibo[i] = fibo[i - 2] + fibo[i -1]; 
    }
    return fibo;
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

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = Fibonacci(num);
PrintArray(arr);