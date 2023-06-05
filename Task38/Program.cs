double[] GetRealArray(int size, int Value)
{
    double[] resultArray = new double[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = Math.Round(new Random().NextDouble() * (Value), 2);
    }
    return resultArray;
}

double[] FindMaxMinDiff(double[] arr){
    double min = arr[0];
    double max = arr[0];
    double diff = 0;
    for(int i = 0; i < arr.Length; i++)
    if (arr[i] < min)
    {
        min = arr[i];
    }
    for(int i = 0; i < arr.Length; i++){
      if (arr[i] > max)
    {
        max = arr[i];
    }  
    }
    diff = Math.Round((max - min), 2);
    Console.WriteLine($"Разница между максимальным[{max}] и минимальным[{min}] элементами массива[{String.Join("; ", arr)}] равна:[{diff}]");
    return arr;
}

double[] array = GetRealArray(8, 50);
double[] arrDiff = FindMaxMinDiff(array);
