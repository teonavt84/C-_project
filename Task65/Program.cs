﻿/*Задача 65. Задайте значения M и N. Напишите программу, которая num
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/
void PrintNaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        PrintNaturalNumbers(numM, numN - 1);
        Console.Write($"{numN} ");
    }
    if (numM > numN)
    {
        PrintNaturalNumbers(numM, numN + 1);
        Console.Write($"{numN} ");
    }
    if (numM == numN)
        Console.Write($"{numN} ");

}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(m, n);