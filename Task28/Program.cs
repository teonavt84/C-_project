// Задача 28. Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int Factorial(int num)
{

    int i = 1;
    int factNum = 1;
    while (i <= (int)Math.Abs(num))
    {
        checked
        {
            factNum = factNum * i;
            i++;
        }
    }
    return factNum;
}
Console.WriteLine("Введите число: ");
int number; // = Convert.ToInt32(Console.ReadLine());
if (int.TryParse(Console.ReadLine(), out number))
{
    if (number > 0)
        Console.WriteLine($"Произведение чисел от 1 до {number} равно {Factorial(number)}.");
    else
        Console.WriteLine("Введите натуральное число.");
}
else
    Console.WriteLine("Введите целое число.");