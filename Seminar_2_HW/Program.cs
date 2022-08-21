// Задача 10 нужно решить через ЦЕЛЫЕ ЧИСЛА, без строчек
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трёхзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Вторая цифра этого числа: {(a / 10) % 10}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите любое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 0) number = number * (-1);
// string numberStr = number.ToString();

// if (numberStr.Length >= 3) Console.WriteLine($"третья цифра введенного числа это - {numberStr[2]}");

// else Console.WriteLine("третьей цифры нет");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру обозначающую день недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7) Console.Write("Да это выходной");
else Console.Write("Нет это не выходной");