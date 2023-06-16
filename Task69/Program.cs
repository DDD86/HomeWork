// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());

int GetPow(int number, int degree)
{
    if (degree == 0) return 1;
    return number * GetPow(number, degree - 1);
}

Console.WriteLine($"Число {A} в степени {B} равно: {GetPow(A, B)}");