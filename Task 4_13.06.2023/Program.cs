﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.//
//2, 3, 7 -> 7//
//44 5 78 -> 78//
//22 3 9 -> 22//

Console.Clear();
Console.Write("Input a = ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input b = ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input c = ");
int c = Convert.ToInt32 (Console.ReadLine());
int max = a;
    if (b > max) max=b;
    if (c > max) max=c;
Console.Write ($"MAX = {max}");