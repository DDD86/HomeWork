// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string GetNaturalNumbers(int end, int start)
{
    if (end == start) return end.ToString(); 

    return end + ", " + GetNaturalNumbers(end - 1, start);
}

Console.WriteLine($"Натуральные числа от {N} до 1: [{GetNaturalNumbers(N, 1)}]");
