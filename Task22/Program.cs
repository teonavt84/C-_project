// Задача 22. Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// void TabSquare(int number)
// {
//     int count = 1;
//     while (count <= number)
//     {
//         Console.WriteLine($"{count} {count * count,5}");
//         count++;
//     }
// }
// Console.WriteLine($"Таблица квадратов для числа {num}:");
// TabSquare(num);

// Через цикл for
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void TabSquare(int num)
{
    for (int i = 1; i <= num; i++)
        Console.WriteLine($"{i} {i * i,5}");
}
Console.WriteLine($"Таблица квадратов для числа {number}:");
TabSquare(number);