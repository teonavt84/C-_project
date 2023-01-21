// Задача 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
// 1-я плоскость x > 0 y > 0
// 2-я плоскость x > 0 y < 0
// 3-я плоскость x < 0 y < 0
// 4-я плоскость x < 0 y > 0
Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int quarter = Quarter(x, y);
string result = quarter > 0
        ? $"Указанные координаты соответствуют четверти {quarter}"
        : "Введеные неверные координаты.";
Console.WriteLine(result);
int Quarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}