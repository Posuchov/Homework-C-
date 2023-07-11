//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;
Clear();
WriteLine("Input M. ");
int a = int.Parse(ReadLine()!);

WriteLine("Input N. ");
int b = int.Parse(ReadLine()!);

WriteLine(PrintNumbers(a, b));

int PrintNumbers(int a, int b)
{
    if (b == a || b == 1)
    {
        return 1;
    }
    int s = PrintNumbers(a, b - 1)+b;
    return s;
}