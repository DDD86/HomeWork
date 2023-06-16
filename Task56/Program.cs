//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = GetMatrix(4, 4, 10);

PrintMatrix(matrix);

int[,] GetMatrix(int m, int n, int value)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MinRowSumOfArray(int[,] array)
{
    int min = int.MaxValue;
    int line = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {

            sum += array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            line = i + 1;
        }
    }
    Console.WriteLine($"Наименьшая сумма: [{min}], находится в строке: [{line}]");
}

MinRowSumOfArray(matrix);



