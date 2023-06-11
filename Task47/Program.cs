//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] resMatrix = GetMatrix(rows, columns, 100);

PrintMatrix(resMatrix); 

double[,] GetMatrix(int m, int n, int value)
{
    double[,] matrix = new double[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (value), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}