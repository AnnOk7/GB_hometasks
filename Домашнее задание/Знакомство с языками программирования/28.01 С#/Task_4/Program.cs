//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();

Console.WriteLine($"Введите 3 числа ");
int Num1 = int.Parse(Console.ReadLine()!);
int Num2 = int.Parse(Console.ReadLine()!);
int Num3 = int.Parse(Console.ReadLine()!);

if (Num1>Num2)
{
    if (Num1>Num3)
    {
        Console.WriteLine($"Max = {Num1}");
    }
    else
    {
        Console.WriteLine($"Max = {Num3}");
    }
}
else if (Num2>Num3)
{
    Console.WriteLine(Num2);
}
else
{
Console.WriteLine($"Max = {Num3}");
}
