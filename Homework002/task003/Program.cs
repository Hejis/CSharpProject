// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели : "); // тут оставил на русском )
int day = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(day);
if (day >= 1 && day <= 5)
{
    Console.WriteLine("workday"); // рабочий день ..
}
else if (day >= 6 && day <=7)
{
    Console.WriteLine("weekend"); // выходной ден / выходные дни.. 
}
else 
{
    Console.WriteLine("Please enter the correct number "); // пытаюсь все делать на АНГ )
}
