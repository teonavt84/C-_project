﻿// Задача 22. Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void TabSquare(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count} {count * count}");
        count++;
    }
}
Console.WriteLine($"Таблица квадратов для числа {num}:");
TabSquare(num);