// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 21;
// int b1 = 13;
// int c1 = 666;
// int a2 = 22;
// int b2 = 23;
// int c2 = 1161;
// int a3 = 12;
// int b3 = 73;
// int c3 = 41;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);

// // int max = Max(max1, max2, max3);

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


// Console.WriteLine("max = " + max);

// 9. Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int randomNumber = new Random().Next(10, 100);

// int firstDigit = randomNumber / 10;
// int secondDigit = randomNumber % 10;

// int maximum = firstDigit;
// if(secondDigit > maximum) maximum = secondDigit;
// Console.WriteLine($"Максимальная цифра в числе {randomNumber} это {maximum}");

// string test = "Hello, world!";
// System.Console.WriteLine(test[7]);

// Задача 10 нужно решить через ЦЕЛЫЕ ЧИСЛА, без строчек
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трёхзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Вторая цифра этого числа: {(a / 10) % 10}");

// 11. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// string number;
// number = Convert.ToString(new Random().Next(100, 1000));

// System.Console.WriteLine(number);
// System.Console.WriteLine(number[0] + "" + number[2]);

//второй вариант

// int number = new Random().Next(100,1000); // [100;1000)
// // 456 / 100 =4 
// // 4 * 10 = 40

// // 456 -> 6: 456 % 10
// int result = (number / 100) * 10 + (number % 10);

// Console.WriteLine($"Рандомное число: {number}, result: {result}");


// 12. Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли первое число кратным второму. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// System.Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a % b == 0)
// {
//     System.Console.WriteLine("кратно");
// }
// else System.Console.WriteLine($"остаток {a % b}");

// Второе решение задачи (Преподаватель)

// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber % secondNumber == 0) Console.WriteLine("Кратно");

// else Console.WriteLine($"Не кратно, остаток от деления {firstNumber % secondNumber}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * (-1);
string numberStr = number.ToString();

if (numberStr.Length >= 3) Console.WriteLine($"третья цифра введенного числа это - {numberStr[2]}");

else Console.WriteLine("третьей цифры нет");


// 14. Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// System.Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 7 == 0 && a % 23 == 0)
// {
//     System.Console.WriteLine("кратно");
// }
// else System.Console.WriteLine("не кратно");

// "&&" - "И"
// 1 && 1 -> True(1)  и 0 && 0 -> False(0)
// купить яблоки и апельсины - одновременно купить и то, и то
// нужно купить и яблоки, и апельсины обязательно

// "||" - "ИЛИ"
// купить яблоки или апельсины
// ХОТЯ бы 1 условие должно быть выполнено
// купить яблоки, или купить апельсины; можно купить яблоки и апельсины

// int number = Convert.ToInt32(Console.ReadLine());
// // Число делится на 7 и на 23 -> "&&" или "||"?
// if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Кратно");

// else Console.WriteLine("НЕ кратно");

// string.Length


