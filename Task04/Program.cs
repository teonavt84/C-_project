// Задача 4. Напишите программу, которая принимает наи вход три числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberOne > max)
    max = numberOne;
if (numberTwo > max)
    max = numberTwo;
if (numberThree > max)
    max = numberThree;
Console.WriteLine($"Максимальное число из введенных {max}");