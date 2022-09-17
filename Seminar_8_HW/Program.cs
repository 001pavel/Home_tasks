int[,] GetIntMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++) // строчки, matrix.GetLength(0) = m
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами
        }
        Console.WriteLine();
    }
}

//Задача 54(ДЗ): Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54()
{
    Random rand = new Random();
    int rows = rand.Next(3, 8);
    int columns = rand.Next(3, 6);

    int[,] matrix = GetIntMatrix(rows, columns, 0, 10);
    Console.WriteLine("Задан массив:");
    PrintMatrix(matrix);
    Console.WriteLine();

    for (int n = 0; n < rows; n++)
    {
        int temp;
        for (int i = 0; i < columns; i++)
        {
            for (int j = i + 1; j < columns; j++)
            {
                if (matrix[n, i] < matrix[n, j])
                {
                    temp = matrix[n, i];
                    matrix[n, i] = matrix[n, j];
                    matrix[n, j] = temp;
                }
            }
        }
    }
    Console.WriteLine("В итоге получен такой массив:");
    PrintMatrix(matrix);
}
//Zadacha54();

// Задача 56(ДЗ): Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[] GetArraySum(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i] += matrix[i, j];
        }
    }
    return array;
}


void Zadacha56()
{
    Random rand = new Random();
    int rows = rand.Next(3, 6);
    int columns = rand.Next(3, 6);

    int[,] matrix = GetIntMatrix(rows, columns, 0, 9);
    PrintMatrix(matrix);
    Console.WriteLine();

    int[] arr = GetArraySum(matrix);
    //for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);

    int sumMin = arr[0];
    int posArr = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (sumMin > arr[i]) sumMin = arr[i];
        if (sumMin == arr[i]) posArr = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой ({sumMin}) элементов: {posArr + 1}");
}

//Zadacha56();

//Задача 58(ДЗ): Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Zadacha58()
{
    Random randA = new Random();
    int rowsA = randA.Next(2, 5);
    int columnsA = randA.Next(2, 4);

    Random randB = new Random();
    int rowsB = randB.Next(2, 4);
    int columnsB = randB.Next(2, 5);

    int[,] matrixA = GetIntMatrix(rowsA, columnsA, 0, 9);
    PrintMatrix(matrixA);
    Console.WriteLine();

    int[,] matrixB = GetIntMatrix(rowsB, columnsB, 0, 9);
    PrintMatrix(matrixB);
    Console.WriteLine();

    int[,] matrixMultAB = new int[rowsA, columnsB];

    if (columnsA == rowsB)
    {
        Console.WriteLine("Матрицы согласованы и их можно перемножить");
        Console.WriteLine();
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                int sum = 0;
                for (int n = 0; n < columnsA; n++)
                {
                    sum += matrixA[i, n] * matrixB[n, j];
                }
                matrixMultAB[i, j] = sum;
            }
        }
        Console.WriteLine("Результат умножения матриц: ");
        PrintMatrix(matrixMultAB);
    }

    else Console.WriteLine("Матрицы не согласованы и их нельзя перемножить");
}

Zadacha58();