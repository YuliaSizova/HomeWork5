/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов,
 стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/



    int[] GetRandomArray(int length)
    {
        int[] result = new int[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = new Random().Next(10, 1000);
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


int GetSumElement(int[] num)
{

    int temp = 0;

    for (int i = 0; i < num.Length; i++)
    {
        if (i % 2 >0)
        {
            temp = temp + num[i];

        }

    }
    return temp;
}



int[] arr = GetRandomArray(5);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("суммa элементов,стоящих на нечётных позициях " + GetSumElement(arr));