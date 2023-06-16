// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Input Number: ");
int N = int.Parse(Console.ReadLine()!);
int a = N%10;
int b = N%100/10;
int c = N/10000;
int d = N/1000%10;
  if (a == c)
   {
    if (b==d) Console.WriteLine ("YES");
   } 
else Console.WriteLine ("NO");