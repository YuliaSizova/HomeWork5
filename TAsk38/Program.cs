/*Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/



int[] arr = GetRandomArray(10);
PrintArray(arr);
Console.WriteLine();

Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {arr[GetMaxNumbers(arr)] - arr[GetMinNumbers(arr)]}");


int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(1, 100);
    }

    return result;
}


void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item + " ");
    }
}


int GetMinNumbers(int[] num)
{
    int minIndex = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] < num[minIndex])
        {
            minIndex = i;
        }

    }
    return minIndex;
}


int GetMaxNumbers(int[] num)
{
    int maxIndex = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > num[maxIndex])
        {
            maxIndex = i;
        }

    }
    return maxIndex;
}
 
