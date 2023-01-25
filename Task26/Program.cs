// Задача 26. Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int QuantityNumbers(int num)
{
    if (num < 0) num = num * -1;
    int count = 0;
    while ((int)Math.Abs(num) > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int quantityNumbers = QuantityNumbers(number);
Console.WriteLine($"Количество цифр числа {number} равна {quantityNumbers}");
