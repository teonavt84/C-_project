// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double Distance(int cx1, int cy1, int cz1, int cx2, int cy2, int cz2)
{
    double dist = Math.Sqrt(((cx1 - cx2) * (cx1 - cx2)) + ((cy1 - cy2) * (cy1 - cy2)) + ((cz1 - cz2) * (cz1 - cz2)));
    return dist;
}
double dist = Distance(x1, y1, z1, x2, y2, z2);
double distRound = Math.Round(dist, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками по координатам A ({x1}, {y1}, {z1}) и B ({x2}, {y2}, {z2}) равно {distRound}");