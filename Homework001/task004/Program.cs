// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N. 
// 5 -> 2, 4 
// 8 -> 2, 4, 6, 8 
 
Console.Write("введите число : "); 
int N = Convert.ToInt32(Console.ReadLine()); 
int start_N = 1; 
while (start_N <= N)  
{ 
    if (start_N % 2 == 0) 
    Console.Write(start_N + ","); 
    start_N++;  
}