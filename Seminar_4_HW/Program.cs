// Задача 25(ДЗ): Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите два числа: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int result = 1;
// for (int i = 1; i <= secondNumber; i++)
// {
//     result *= firstNumber;
// }

// Console.WriteLine($"{firstNumber} ^ {secondNumber} = {result}");


// вариант решения с применением метода
// int RaiseNumberToPower(int firstNumber, int secondNumber)
// {
//     int result = 1;
//     for (int i = 1; i <= secondNumber; i++)
//     {
//         result *= firstNumber;
//     }
//     return result;
// }

// Console.WriteLine("Введите два числа: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// int secondNum = Convert.ToInt32(Console.ReadLine());

// // int res = RaiseNumberToPower(firstNum, secondNum);
// // Console.WriteLine($"{firstNum} ^ {secondNum} = {res}");

// Console.WriteLine($"{firstNum} ^ {secondNum} = {RaiseNumberToPower(firstNum, secondNum)}");

// Задача 27(ДЗ): Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int num = A;
// int sum = 0;

// while (A > 0) 
// {
//     sum += A % 10;
//     A /= 10;
// }

// Console.Write($"Сумма цифр в числе {num} равна {sum}");

// Вариант решения с применением метода
// int GetNumberSum(int num)
// {
//     int sum = 0;
//     while (num > 0) 
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     return sum;
// }

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Сумма цифр в числе {A} равна {GetNumberSum(A)}");

// Задача 29 (ДЗ): Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 100);
// }

// Console.Write($"[{String.Join(", ", array)}]");

// вариант решения с применением метода
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

Console.Write($"[{String.Join(", ", GetArray(8))}]");