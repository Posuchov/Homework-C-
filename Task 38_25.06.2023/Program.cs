// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


Console.Clear();
double[] BigArray(int number, double minValue, double maxValue)
{
    double[]result = new double[number];
    for (int i = 0; i < number; i++)
    {
       result[i] = new Random(). NextDouble() * (maxValue - minValue +1) + minValue;   
    }

    return result;
}

void Minmax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
Console.WriteLine($"Min Size {min:f2}");
Console.WriteLine($"Max Size {max:f2}");
Console.WriteLine($"difference {max-min:f2}");
}
double[] arr = BigArray(5, -5, -5);
Console.WriteLine(String.Join(" ", arr));
Minmax(arr);