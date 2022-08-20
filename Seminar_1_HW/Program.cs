// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// Пример
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a != b)
{
    if (a > b)
    {
        Console.WriteLine("число " + a + " больше числа " + b);
    }
    else Console.WriteLine("число " + b + " больше числа " + a);

}
else Console.WriteLine("числа не должны быть одинаковыми");