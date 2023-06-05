int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] FindOddNumSum(int[] arr){
    int evenNumbers = 0;
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    if (arr[i] % 2 == 1)
    {
        evenNumbers = arr[i];
        sum = sum + evenNumbers;
    }
    Console.WriteLine($"Сумма нечетных чисел данного массива равна: {sum}");
    return arr;
}

int[] array = GetArray(10, 1, 20);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
int[] arr = FindOddNumSum(array);