// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void TableSquad(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($" {i} -> {i * i * i}");
    }
}
Console.WriteLine($"Таблица кубов для числа {number}:");
TableSquad(number);