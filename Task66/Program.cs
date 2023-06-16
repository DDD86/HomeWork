// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int GetSumOfNumbers(int start, int end)
{
    if (start == end) return start;

    return start + GetSumOfNumbers(start + 1 , end);
}

Console.WriteLine($"Сумма натуральных чисел в промежутке от [{M}] до [{N}] равно: [{GetSumOfNumbers(M, N)}]");
