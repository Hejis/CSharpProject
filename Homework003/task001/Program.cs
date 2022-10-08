//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да


Console.WriteLine("Введите число : ");
int nums = Convert.ToInt32(Console.ReadLine());

string checkPolindrome (int num)
{
    int pal = 0; 
    int number = num;
    while (number > 0) 
    {
        pal = pal * 10 + number % 10;
        number = number / 10;
    }
    return num == pal ? "палиндром" : "не палиндром";
}
Console.WriteLine(checkPolindrome(nums));