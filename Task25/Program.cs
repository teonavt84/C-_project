﻿// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 3 * 3 * 3 * 3 * 3
int Exponentiation(int numOne, int numTwo)
{
    int expo = 1;
    for (int i = 0; i < numTwo; i++)
    {
        checked
        {
            expo = expo * numOne;
        }
    }
    return expo;
}
Console.WriteLine("Введите число");
Console.Write("A: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne < 0 | numberTwo < 0)
    Console.WriteLine("Введенное число должно быть больше нуля.");
else
Console.WriteLine($"Возведение в степень числа {numberOne} {numberTwo} {Exponentiation(numberOne, numberTwo)}");