// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int NumberDeg(int number, int n)
{
	int res = number;
	for (int i = 1; i < n; i++)
	{
		res *= number;
	}
    Console.WriteLine($"Число {number} в степени {n} равно: {res}");
	return res;
}

NumberDeg(5, 2);