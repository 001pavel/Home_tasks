// Задача 64(ДЗ): Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Console.WriteLine("Введите по порядку два числа M и N:");
// int M = Convert.ToInt32(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());
// if (M > N) return;
// string PrintNumbers(int start, int end)
// {
//     // base case
//     if (start == end) return start.ToString();
//     // recursion case
//     return (start + ", " + PrintNumbers(start + 1, end));
// }
// Console.WriteLine("Все натуралные числа от M до N:");
// Console.WriteLine(PrintNumbers(M, N));

// Задача 66(ДЗ): Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.WriteLine("Введите по порядку два числа M и N:");
// int M = Convert.ToInt32(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());
// if (M > N) return;

// int SumNumbers(int start, int end)
// {
//     // base case
//     if (start == end) return start;
//     // recursion case
//     return (start + SumNumbers(start + 1, end));
// }
// Console.WriteLine($"Cумма натуралных чисел от M до N = {SumNumbers(M, N)}");

// Задача 68(ДЗ): Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите по порядку два числа M и N:");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
if (M < 0 || N < 0) return;

int FuncAkkerman(int m, int n)
{
    if (m == 0) return n + 1;    
    else if (m > 0 && n == 0) return FuncAkkerman(m - 1, 1);
    else if (m > 0 && n > 0) return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));

    else return -1;
}
Console.WriteLine($"result = {FuncAkkerman(M, N)}");