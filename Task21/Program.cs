﻿Console.Write("Введите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у1: ");
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками А:({x1},{y1},{z1}), В:({x2},{y2},{z2}) равно: {Math.Round(d,2)}"); 