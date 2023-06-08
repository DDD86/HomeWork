Console.Write("Введите количестиво чисел в массиве: ");
int size;
size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа массива: ");
int[] array = new int[size];
int numbers;
for (int i = 0; i < size; i++)
{

    numbers = Convert.ToInt32(Console.ReadLine());
    array[i] = numbers;
}
Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}]");

void CheckNumbers(int[] arr)
{
    int countOfposNum = 0;
    int countOfNull = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            countOfposNum++;
        }
        else
        {
            countOfNull++;
        }
    }
    
    if (countOfposNum == 0)
    {
        Console.Write($"В данном массиве нет чисел больше нуля! Количество нулей: {countOfNull}");
    }
    else if (countOfNull == 0)
    {
        Console.Write($"В данном массиве нет нулей! Чисел в данном массиве больше нуля: {countOfposNum}");
    }
    else
    {
        Console.Write($"Чисел в данном массиве больше нуля: {countOfposNum}, количество нулей: {countOfNull}");
    }
}

CheckNumbers(array);

