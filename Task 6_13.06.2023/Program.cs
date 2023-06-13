//Задача 6:Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).//
// 4 -> да
//-3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Input a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Input b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("Input c = ");
int c = int.Parse(Console.ReadLine());
  if (a%2==0)
{Console.WriteLine($"even number а = {a}");}
  if (b%2==0)
{Console.WriteLine($"even number b = {b}");}
  if (c%2==0)
{Console.WriteLine($"even number c = {c}");}