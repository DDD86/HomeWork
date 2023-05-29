int numberCheck0;
int numberCheck1;
int numberCheck2;
int numberCheck3;
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Введено не пятизначное число!");
}
else
{
numberCheck0 = number / 1000; // нахождение первых двух цифр вводимого числа.
numberCheck1 = number % 10; // нахождение последней цифры числа.
numberCheck2 = (number % 100)/10; // нахождение предпоследней цифры.
numberCheck3 = (numberCheck1 * 10) + numberCheck2; // слияние в обратном порядке предпоследней и последней цифр.

if (numberCheck0 == numberCheck3)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
}

//Нахождение с помощью string:
// Console.Write("Введите пятизначное число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// string number2 = Convert.ToString(number1);
// if (number1 < 10000 || number1 > 99999)
// {
//     Console.WriteLine("Введено не пятизначное число!");
    
// }
// else if (number2[0] == number2[4] && number2[1] == number2[3])
// {
//    Console.WriteLine($"Число {number2} является палиндромом"); 
// }
// else
// {
//     Console.WriteLine($"Число {number2} не является палиндромом");
// }