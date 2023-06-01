//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int size = 8;
int[] array = new int[size]; 
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rand.Next(1, 9);
}

Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");