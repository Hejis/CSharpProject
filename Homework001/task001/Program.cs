﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
// a = 5; b = 7 -> max = 7 
// a = 2 b = 10 -> max = 10 
// a = -9 b = -3 -> max = -3 

Console.Write("Введите первое число : "); // выводит в консоль задачу пользвателью  
int a = Convert.ToInt32(Console.ReadLine()); // записвает в переменную число заданное число пользователем (конвертирует в инт)  
Console.Write("Ввелдите втрое число : ");  
int b = Convert.ToInt32(Console.ReadLine()); 
 
if (a > b) // Иф - если выпражение истинно то выпольнается первое   
{ 
    Console.WriteLine("максимальное число : " + a); 
    Console.WriteLine("минимальное число  : " + b ); 
} 
 
else if (a == b) 
{ 
    Console.WriteLine("Числа равны"); 
} 
 
else // иначе выводит  
{ 
    Console.WriteLine("максимальное число =  " + b);
    Console.WriteLine("минимальное число =  "  + a); 
}