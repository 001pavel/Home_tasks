// Задача 41(ДЗ): Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Сколько чисел вы собираетесь ввести?: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// for (int i = 1; i <= m; i++)
// {
//     Console.Write($"Введите {i} число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 0) count++;
// }
// Console.WriteLine($"Всего пользователь ввел {count} число(ла, ел) больше 0");


// Задача 43 (ДЗ): Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Последовательно задайте значения b1, k1, b2 и k2: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// double k1 = Convert.ToInt32(Console.ReadLine());
// double b2 = Convert.ToInt32(Console.ReadLine());
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Точка пересечения двух прямых заданных уравнениями y = {k1}x + {b1} и y = {k2}x + {b2} имеет координаты ({x}; {y}) ");

// Дополнительное задание: перевести число из 10 СС(системы счисления) в 2
// Сложный вариант.

string DesToBin(int numDes)
{
    string numBin = "";
    while (numDes > 0)
    {
        if (numDes % 2 == 0) numBin += "0";
        else numBin += "1";
        numDes = numDes / 2;
    }

    string numBinRev = "";
    for (int i = 0; i < numBin.Length; i++)
    {
        numBinRev += numBin[numBin.Length - 1 -i];
    }
    return numBinRev;
}

Console.Write("Введите число в десятичной системе исчисления: ");
// int numDes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат в двоичной системе: {DesToBin(Convert.ToInt32(Console.ReadLine()))}");

// Простой вариант.
string ConvertToBin(int num)
{
    return Convert.ToString(num, 2);
}

Console.Write("Введите число в десятичной системе исчисления: ");
Console.WriteLine($"Результат в двоичной системе: {ConvertToBin(Convert.ToInt32(Console.ReadLine()))}");