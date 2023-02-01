﻿// Задача 45. Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
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

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    //int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] arr = CreateArray(10, 10, 100);
PrintArray(arr);
int[] newArr = CopyArray(arr);
Console.WriteLine();
PrintArray(newArr);