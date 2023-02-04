/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
double FindPointX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}
double FindPointY(double b1, double k1, double b2, double k2)
{
    return k1 * (b2 - b1) / (k1 - k2) + b1;
}

Console.WriteLine("Введите координаты линий:");
Console.Write("Введите координаты точки b1: ");
double cb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки k1: ");
double ck1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки b2: ");
double cb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки k2: ");
double ck2 = Convert.ToInt32(Console.ReadLine());
if (ck1 == ck2 && cb1 == cb2)
{
Console.WriteLine("Прямые совпадают.");
return;
}
if (ck1 == ck2) 
{
Console.WriteLine("Прямые являются параллельными.");
return;
}
double x = FindPointX(cb1, ck1, cb2, ck2);
double y = FindPointY(cb1, ck1, cb2, ck2);
Console.WriteLine($"b1 = {cb1}, k1 = {ck1}, b2 = {cb2}, k2 = {ck2} -> ({x};{y})");