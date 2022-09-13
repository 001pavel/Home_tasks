// Создание матрицы и заполение случайными целыми числами
int[,] GetIntMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}
// Создание матрицы и заполение случайными вещественными числами
double[,] GetDoubleMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 10 - 5, 2);
        }
    }
    return matrix;
}

// Напечатать массив с целыми числами
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Напечатать массив с вещественными числами
void PrintDoubleMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Zadacha47()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    // double[,] resultMatrix = GetDoubleMatrix(rows, columns);
    // PrintDoubleMatrix(resultMatrix);
    PrintDoubleMatrix(GetDoubleMatrix(rows, columns));
}

//Zadacha47();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void Zadacha50()
{
    Random rand = new Random();
    int rows = rand.Next(3, 6);
    int columns = rand.Next(3, 6);

    int[,] resultMatrix = GetIntMatrix(rows, columns, 0, 10);
    PrintMatrix(resultMatrix);

    Console.Write("Введите номер строки: ");
    int posRow = Convert.ToInt32(Console.ReadLine()) - 1;

    Console.Write("Введите номер столбца: ");
    int posColumn = Convert.ToInt32(Console.ReadLine()) - 1;

    int rowsLength = resultMatrix.GetLength(0);
    int columnsLength = resultMatrix.GetLength(1);

    if (posRow >= 0 
        && posColumn >= 0 
        && posRow < rowsLength 
        && posColumn < columnsLength) 
        Console.WriteLine($"Искомый элемент матрицы = {resultMatrix[posRow, posColumn]}");
    else Console.WriteLine($"{posRow + 1}, {posColumn + 1} - Такого элемента в матрице не существует");  
}

//Zadacha50();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    Random rand = new Random();
    int rows = rand.Next(2, 4);
    int columns = rand.Next(2, 4);

    int[,] resultMatrix = GetIntMatrix(rows, columns, 0, 10);
    PrintMatrix(resultMatrix);
    Console.WriteLine();

    int rowsLength = resultMatrix.GetLength(0);
    int columnsLength = resultMatrix.GetLength(1);

    double sumColumn = 0;
    string textResult = String.Empty;

    for (int i = 0; i < columnsLength; i++)
    {
        for (int j = 0; j < rowsLength; j++)
        {
            sumColumn += resultMatrix[j, i];
        }
        double result = Math.Round(sumColumn/rowsLength, 2);
        textResult += result + "; ";
        sumColumn = 0;
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {textResult}");
}

Zadacha52();