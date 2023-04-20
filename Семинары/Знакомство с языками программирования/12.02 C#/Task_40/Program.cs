// Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.

bool CheckTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
}

Console.WriteLine("Введите первое число");
int x  = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int y  = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int z  = int.Parse(Console.ReadLine()!);

if (CheckTriangle(x, y, z))
{
    Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такой треугольник не существует");
}