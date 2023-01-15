// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится на два без остатка).
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
    Console.WriteLine($"{number} является четным числом.");
else
    Console.WriteLine($"{number} не является четным числом.");