//Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа по убыванию в промежутке от M до N

using System;
using static System.Console;
Clear();

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(m, n));

string PrintNumbers(int start, int end)
{
    if (end == start) return end.ToString();
    return (end + " " + PrintNumbers(start, end - 1));
}