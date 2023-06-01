//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
int lastDigit = 0;
int sum = 0;
while (number!=0){
    lastDigit = number%10;
    sum = sum + lastDigit; 
    number /= 10;   
}
Console.WriteLine($"Сумма цифр в числе {number}, равна: {sum}");



