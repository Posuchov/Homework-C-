// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.//
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Input xxx three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
if (amount < 3 || amount > 3)
    {
    Console.WriteLine("!not a three digit number!");
    }
else
    {
    Console.WriteLine(InCenter(number));
    }

int InCenter(int a)
    {
        int result = ((a/10)%10);
        return result;
    }