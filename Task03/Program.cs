﻿// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Неправильно введен номер дня.");
        break;
}