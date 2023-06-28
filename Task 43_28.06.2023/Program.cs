// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

Console.WriteLine("Input b1 and k1: ");
double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Input b2 and k2");
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine();

if (k1 == k2) Console.WriteLine($"b1={b1}, k1={k1}; b2={b2}, k2={k2} -> lines don't cross");
else
{
    double x = (b2 - b1) / (k1 - k2);
    // Console.WriteLine($"x1 = x2 = {x}");
    double y1 = k1 * x + b1;
    // Console.WriteLine($"y1 = {y1}");
    double y2 = k2 * x + b2;
    // Console.WriteLine($"y2 = {y2}");
    // Console.WriteLine();
    Console.WriteLine($"b1={b1}, k1={k1}; b2={b2}, k2={k2} -> ({x}; {k1 * x + b1})");
}