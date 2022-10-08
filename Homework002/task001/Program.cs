// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString(); // тут переобразовал числовую строку на текстовую чтобы найти по иддексу ..

if (str.Length > 1)
{
    Console.WriteLine($"number two {str[1]} "); //простите за мой АНГ )
}
else
{
    Console.WriteLine("NO number two"); //простите за мой АНГ )
}