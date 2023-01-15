// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100 && number < 1000)
    {
        int lastCharacter = number % 10;
        Console.WriteLine($"Последяя цифра {number} равна {lastCharacter}");
    }
else
    Console.WriteLine("Введенное число должно быть трехзначным.");