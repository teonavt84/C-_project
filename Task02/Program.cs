// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne > numberTwo)
{
    Console.WriteLine($"{numberOne} больше, {numberTwo} меньше.");
}
else
    Console.WriteLine($"{numberTwo} больше, {numberOne} меньше");