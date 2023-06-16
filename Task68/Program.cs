// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int GetAckermannFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return GetAckermannFunc(m - 1, 1);
    return GetAckermannFunc(m - 1, GetAckermannFunc(m, n - 1));
}

Console.WriteLine($"[{GetAckermannFunc(M, N)}]");