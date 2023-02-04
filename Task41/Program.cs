/*Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/
void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
        if(i < array.Length - 1)  
        Console.Write($"{array[i]}, ");
        else 
        Console.Write($"{array[i]}");
   }
}

int NumberOfZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count+=1;
    }
    return count;
}

int[] StringToArray(string num)
{
    string[] numbers = num.Split(',');   
    int[] array = new int[numbers.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(numbers[i]);
    }
    return array;
}
Console.Clear();
Console.Write("Введите числа через запятую: ");
string numbers = Console.ReadLine()!;
int[] arr = StringToArray(numbers);
PrintArray(arr);
Console.Write(" -> ");
int res = NumberOfZero(arr);
Console.WriteLine(res);