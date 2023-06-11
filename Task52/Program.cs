//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}

int[,] array2d = GetArray2d(rows, columns, 0, 10);
PrintMatrix(array2d);

Console.WriteLine("Введите позицию элемента(номер строки)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента(номер столбца)");
int m = Convert.ToInt32(Console.ReadLine());

if (n >= array2d.GetLength(0) || m >= array2d.GetLength(1))
{
    Console.WriteLine("Вы вышли за пределы массива!");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {array2d[n,m]}");                                  
}
