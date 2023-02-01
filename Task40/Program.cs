// Задача 40. Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
bool Triangle(int a, int b, int c)
{
    return a < b + a && b < a + c && c < a + b;
}
Console.Write("Введите дину отрезка A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите дину отрезка B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите дину отрезка C: ");
int c = Convert.ToInt32(Console.ReadLine());
bool res = Triangle(a, b, c);
Console.WriteLine(res ? "Да" : "Нет");