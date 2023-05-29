int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Int32.Parse(value);
    return result;
}

double thirdDeg;
int number = Prompt("Введите число: ");
for (int i = 1; i <= number; i++)
{
    thirdDeg = Math.Pow(i, 3);
    Console.Write($"{i} в 3 степени равно: {thirdDeg}  \t"); 
}
