// // Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();


int [] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    
    }
    return result;
}

int Count(int[] Array)
{ 
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    { 
       
        if (Array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Какое количество цифр вы хотите ввести?");
int M = int.Parse(Console.ReadLine()!);
int[] NewArray = GetArray(M, -10, 10);
Console.WriteLine(string.Join(", ", NewArray));
int array = Count(NewArray);
Console.WriteLine($"Из введённого количества цифр  {M} - больше 0, {array}  - положительные!");