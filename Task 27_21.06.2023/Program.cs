// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Input number: ");
int a = int.Parse(Console.ReadLine()!);
int b = Math.Abs(Method1(a));
Console.WriteLine($"Sum of number {a} = {b}");

int Method1 (int zahle)
{
    int sum = 0;
    while (zahle !=0)
    {
        sum += zahle % 10;
        zahle /= 10;
    }
    return sum;
}