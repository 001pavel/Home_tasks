// Задача 19(ДЗ). Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine()); //чтобы не вводить буквы, только числа
// // здесь бы проверить введенные символы цифры или буквы, если это буквы то выдать сообщение об этом, но пока не знаю как эту проверку осуществить
// string number_str = number.ToString();

// if (number_str.Length < 5 || number_str.Length > 5) Console.Write("Введенное число не пятизначное");
// else if (number_str[0] == number_str[4] && number_str[1] == number_str[3]) Console.Write("Введенное число является палиндромом");
// else Console.Write("Введенное число не является палиндромом");

// Задача 21(ДЗ). Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(x2 - x1)2 + (y2 - y1)2 + (z2 - z1)2

// Первый вариант с прямым вводом цифр.
// Console.WriteLine("Введите координаты первой точки А: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки В: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

// Console.WriteLine($"Расстояние между точками равно {Math.Round(AB, 2)}");

// Вариант с вводом через цикл for в массив
// int[] array = new int[6];
// Console.WriteLine("Введите координаты двух точек А и В (6 цифр по очереди): ");

// for (int i = 0; i < 6; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// double AB = Math.Sqrt(Math.Pow(array[3] - array[0], 2)
//     + Math.Pow(array[4] - array[1], 2)
//     + Math.Pow(array[5] - array[2], 2));

// Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(AB, 2)}");

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($" {i} ^ 3 = {Math.Pow(i,3)}");
}