// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    for (int i = 0; i < array.Length; i+=2)
    {
        count += array[i];
    }
    return count;
}
int[] arr = BigArray(4, 10, 99);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(Solution(arr));