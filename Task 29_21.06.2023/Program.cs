// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();
int N = 8;
int[]array = new int[N];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)

{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =random.Next(100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}