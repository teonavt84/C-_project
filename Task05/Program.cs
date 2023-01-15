//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числав промежутке от -N до N.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int count = -number; //4
    while (count <= number)
    {
        Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Число должно быть больше нуля.");
}
