﻿//Задача 6:Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).//
// 4 -> да
//-3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number %2 == 0)
{ 
    Console.WriteLine($"{number} event number");
//Если условие (%2==0 - означает "остаток от деления на 2" равен нулю) истина то вывести это число в консоль как чётное.
//Числа 2,4,6 и т.д. делятся на 2 без остатка.
}
else
{ 
    Console.WriteLine($"{number} odd number");
//Если условие ложь то вывести это число в консоль как нечётное.
//Числа 3,5,7 и т.д. делятся на 2 с остатоком 1, следует числа нечётные.   
}