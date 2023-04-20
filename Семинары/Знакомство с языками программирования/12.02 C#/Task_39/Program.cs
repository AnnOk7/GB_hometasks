// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем )

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    
    }
    return result;
}

void ReversArray1(int [] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray [inArray.Length - 1 - i] = temp;
    }
}

int [] array = GetArray(6, 0, 10);
Console.WriteLine(string.Join(", ", array));
ReversArray1(array);
Console.WriteLine(string.Join(", ", array));