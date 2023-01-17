// Задача 8. Напишите программу, которая на входе принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (num < 0)
    {
        Console.WriteLine("Введенное число должно быть целым.");
    }
if (num == 1)
    {
        Console.WriteLine("У этого числа нет четных чисел.");
    }
while(i <= num)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
        i++;
}    