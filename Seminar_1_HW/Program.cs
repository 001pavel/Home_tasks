// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a != b)
// {
//     if (a > b)
//     {
//         Console.WriteLine("число " + a + " больше числа " + b);
//     }
//     else Console.WriteLine("число " + b + " больше числа " + a);

// }
// else Console.WriteLine("числа не должны быть одинаковыми");

// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите три не одинаковых числа");
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;

// Console.WriteLine("Максимальное число из трёх введенных: " + max);

// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0)
// {
//     Console.WriteLine("Введенное число " + a + " является чётным");
// }
// else Console.WriteLine("Введенное число " + a + " является нечётным");

// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1; //задаю начало счетчика, чтобы не было 0

while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}