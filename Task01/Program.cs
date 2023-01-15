//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Enter number 1: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberTwo * numberTwo == numberOne)
{
    Console.WriteLine($"{numberOne} является квадратом {numberTwo}");
}
else
{
    Console.WriteLine($"{numberOne} не является квадратом {numberTwo}");
}