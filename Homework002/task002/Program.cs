// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString(); // тут переобразовал числовую строку на текстовую чтобы найти по индексу ..

if (str.Length > 2)
{
    Console.WriteLine($"number three {str[2]} "); //простите за мой АНГ )
}
else
{
    Console.WriteLine("NO number three"); //простите за мой АНГ )
}
