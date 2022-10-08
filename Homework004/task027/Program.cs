// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int sum = 0;
int res = 0;
int num1;

while (number > 10)
{
    num1 = number % 10;
    sum = sum + num1;
    number = number / 10;
}
if (number<10)
{
    res = sum + number;
}

Console.WriteLine($"Сумма цифр во введенном числе {number} = {res}");