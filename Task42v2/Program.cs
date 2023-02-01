// Задача 42. Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
string Binary(int num)
{
    string res = string.Empty;
    while(num > 0)
    {
    res = num % 2 + res;
    num /= 2;
    }
    return res;
}

Console.Write("Введите число: ");
int num;
if (int.TryParse(Console.ReadLine(), out num))
{
    string res = Binary(num);
    Console.WriteLine(res);
}
else Console.WriteLine("Введено некорректное значение.");