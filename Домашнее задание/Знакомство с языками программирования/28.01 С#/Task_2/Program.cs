// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine($"Введите два числа ");
int Num1 = int.Parse(Console.ReadLine());
int Num2 = int.Parse(Console.ReadLine());

if(Num1>Num2) 
{
Console.WriteLine($"Первое число {Num1} (max) больше второго числа {Num2} (min)");
}
if(Num1<Num2) 
{
Console.WriteLine($"Первое число {Num1} (min) меньше второго числа {Num2} (max)");
}