// Задача 8. Напишите программу, которая на входе принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (number == 1)
{
    Console.WriteLine("У этого числа нет четных чисел.");
}
else
if (number > 0)
    while (i < number)
    {
        Console.Write(i + ", ");
        i += 2;
    }
else
{
    Console.WriteLine("Введенное число должно быть больше нуля");
}