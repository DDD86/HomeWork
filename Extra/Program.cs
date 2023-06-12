//Дополнительное: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д).

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray2d(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
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

int[,] array2d = GetArray2d(rows, columns, 0, 10);
PrintMatrix(array2d);

int MainDiagonalSum(int[,] array)
{
    int numbers = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        numbers = array[i, i];
        Console.Write($"[{numbers}], ");
        sum += array[i, i];
    };
    return sum;
}

int sumOfMainDiag = MainDiagonalSum(array2d);
Console.WriteLine($"Сумма чисел по главной диагонали данного массива равна: {sumOfMainDiag}");

