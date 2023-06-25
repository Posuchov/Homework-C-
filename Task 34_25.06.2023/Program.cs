// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] BigArray(int number, int minValue, int maxValue)
{
    int[]result = new int[number];
    for (int i = 0; i < number; i++)
    {
       result[i] = new Random(). Next(minValue, maxValue +1);   
    }

    return result;
}

int Solution(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if(item%2==0) count ++;
    }
    return count;
}
int[] arr = BigArray(10, 100, 999);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(Solution(arr));