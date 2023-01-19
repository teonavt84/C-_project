// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    number = (number < 0 ? -number : number);
if (number < 100 | number > 999)
{
    Console.WriteLine("Число должно быть трехзначным.");
    return;
}
int FindDigit(int agr1)
{
    int twoDigit = agr1 / 10 % 10;
    return twoDigit;
}
Console.WriteLine($"Вторая цифра" + " " + FindDigit(number));