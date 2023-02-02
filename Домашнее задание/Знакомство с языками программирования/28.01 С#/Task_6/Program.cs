// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.WriteLine($"Введите число ");
int Num1 = int.Parse(Console.ReadLine());

if (Num1 % 2 == 0)
{
   Console.WriteLine($"Число {Num1} чётное"); 
}
else
{
    Console.WriteLine($"Число {Num1} нечётное");
} 