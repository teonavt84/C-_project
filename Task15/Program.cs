//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number < 1)
    Console.WriteLine("Значение дня недели должно быть от 1 до 7");
Console.Write($"{number} день недели ");
bool Day(int arg)
{
    bool result = false;
    if (arg == 6 | arg == 7)
        result = true;
    if (result == true) Console.WriteLine("является выходным днем.");
    else
        result = false;
    if (result == false) Console.WriteLine("не является выходным днем.");
    return result;
}
bool day = Day(number);