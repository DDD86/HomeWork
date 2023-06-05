int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] FindEvenNum(int[] arr){
    int evenNumbers = 0;
    int countOfEvenNum = 0;
    Console.WriteLine("В данном массиве четными числами являются: ");
    for(int i = 0; i < arr.Length; i++)
    if (arr[i] % 2 == 0)
    {
        evenNumbers = arr[i];
        countOfEvenNum = countOfEvenNum + 1;
        Console.WriteLine(evenNumbers);
    }
    if (countOfEvenNum == 1){
       Console.WriteLine($"В данном массиве {countOfEvenNum} четное число");  // Условный оператор if расчитан не на все случаи
    }
    else if (countOfEvenNum > 1 && countOfEvenNum < 5){
        Console.WriteLine($"В данном массиве {countOfEvenNum} четных числа");
    }
    else{
        Console.WriteLine($"В данном массиве {countOfEvenNum} четных чисел");
    }
    return arr;
}

int[] array = GetArray(10, 100, 999);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
int[] arrFindNum = FindEvenNum(array);

