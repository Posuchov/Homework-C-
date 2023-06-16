// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int day = ReadInt("Input the day of the week: ");
Console.WriteLine(WorkHolyday(day));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHolyday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("day of the week: " + a + " weekend");
        }
        else
        { 
             Console.Write("day of the week: " + a + " working day");
        }
    }
    else
    {
        Console.Write("number is not a day of the week");
    }
    return "";
}