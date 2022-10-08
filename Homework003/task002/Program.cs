//Задача 21. Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadData(string line) //читаем данные
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double x1 = ReadData("Введите координаты точки A по x");
double y1 = ReadData("Введите координаты точки A по y");
double z1 = ReadData("Введите координаты точки A по z");
double x2 = ReadData("Введите координаты точки B по x");
double y2 = ReadData("Введите координаты точки B по y");
double z2 = ReadData("Введите координаты точки B по z");

double result = Math.Sqrt(
    Math.Pow(x2 - x1, 2) + 
    Math.Pow(y2 - y1, 2) + 
    Math.Pow(z2 - z1, 2));
result = Math.Round(result, 3);
Console.WriteLine(result);



// второй способ --
// int ReadData(string line)
// {
//     Console.WriteLine(line);
//     int number = int.Parse(Console.ReadLine() ?? "");
//     return number;
// }

// void PrintData(string prefix, string value)
// {
//     Console.WriteLine(prefix + value);
// }
// double FindLen(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
// }
// int x1 = ReadData("Введите координату x первой точки:");
// int y1 = ReadData("Введите координату y первой точки:");
// int z1 = ReadData("Введите координату z первой точки:");
// int x2 = ReadData("Введите координату x первой точки:");
// int y2 = ReadData("Введите координату y первой точки:");
// int z2 = ReadData("Введите координату z первой точки:");

// double result = FindLen(x1,y1,z1,x2,y2,z2);
// result = Math.Round(result,5);

// PrintData("Расстояние между точками: ", result.ToString());