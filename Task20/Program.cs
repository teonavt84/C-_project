// Задача 20. Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите координаты");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
double result = Distance(x1, y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Длина отрезка для координат A ({x1}, {y1}); B ({x2}, {y2}) составляет {resultRound}");
double Distance(int cx1, int cy1, int cx2, int cy2)
{
    //double distx = Math.Pow((cx1 - cx2), 2);
    //double disty = Math.Pow((cy1 - cy2), 2);
    //double dist = Math.Sqrt(distx + disty);
    double dist = Math.Sqrt(((cx1 - cx2) * (cx1 - cx2)) + ((cy1 - cy2) * (cy1 - cy2)));
    return dist;
}