// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Input 2 number:");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int D = Degree(A,B);
Console.WriteLine(D);

int Degree(int zahle, int degree)
{
    int i = 1;
    int step = 1;
    while (i <= degree)
    {
        step *= zahle;
        i++;
    }
    return step;
}