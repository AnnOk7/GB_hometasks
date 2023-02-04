//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите X1: ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите X2: ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);


double X = Math.Abs(X1 - X2);
double Y = Math.Abs(Y1 - Y2);
double Z = Math.Abs(Z1 - Z2);

double XX = Math.Pow(X, 2);
double YY = Math.Pow(Y, 2);
double ZZ = Math.Pow(Z, 2);

double result = Math.Sqrt(XX + YY + ZZ);
result = Math.Round(result, 2);

Console.WriteLine($"Расстояние между точками: {result}");
