// Задача 45: Напишите программу,
// которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.

// 2. создать массив
int[] FirstArray(int size)
{
    return new int[10];
}

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;

    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// 3. печать массива
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

int []arr=FirstArray(10);
FillArray(arr);
PrintArray(arr);
