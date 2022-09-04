
int[] RandomArray(int len, int start, int end)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

double[] RandomArrayDouble(int len, int start, int end, int round)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(start, end) + new Random().NextDouble(), round);
    }
    return array;
}


// Задача 34 (ДЗ): Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = RandomArray(10,100,1000);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0) count++;
// }
// Console.WriteLine($"количество четных чисел в массиве {count}");


// Задача 36 (ДЗ): Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = RandomArray(6,-3,3);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// int negSum = 0;
// for (int i = 1; i < array.Length; i++)
// {
//     if (i % 2 != 0) negSum += array[i];
// }
// Console.WriteLine($"Сумма элементов на нечетных позициях в массиве {negSum}");

// Задача 38 (ДЗ): Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = RandomArray(6, 1, 100);
Console.WriteLine($"[{string.Join(", ", array)}]");

int min = array[0];
int max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

Console.WriteLine($"Разница между {max} и {min} равна {max - min}");
Console.WriteLine();

// Вариант решения с цифрами с запятой.
double[] arrayD = RandomArrayDouble(6, 1, 100, 1);
Console.WriteLine($"[{string.Join("; ", arrayD)}]");

double minD = arrayD[0];
double maxD = arrayD[0];

for (int i = 1; i < arrayD.Length; i++)
{
    if (arrayD[i] < minD) minD = arrayD[i];
    if (arrayD[i] > maxD) maxD = arrayD[i];
}

Console.WriteLine($"Разница между {maxD} и {minD} равна {Math.Round(maxD - minD, 2)}");