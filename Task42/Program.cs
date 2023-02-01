// Задача 42. Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
int NumBinary(int number)
{
    int numBin = 0;
    int count = 1;
    while (number > 0)
    {
        numBin = numBin + (number % 2 * count);
        number /= 2;
        count *= 10;
    }
    return numBin;

}
Console.Write("Введите число: ");
int num;
if (int.TryParse(Console.ReadLine(), out num))
{
    int res = NumBinary(num);
    Console.WriteLine(res);
}
else Console.WriteLine("Введено некорректное значение.");