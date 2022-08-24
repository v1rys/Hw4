// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int sum2 = 0;
while (num >= 1)
{
    sum = num % 10;
    sum2 = sum2 + sum;
    num = num /10;
    
}
Console.WriteLine(sum2);

