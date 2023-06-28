Console.Write("Input array length N = ");
int a = int.Parse(Console.ReadLine()!);
int count = 0;

for(int i = 0; i < a; i++)
{
    Console.WriteLine($"input {i+1} number");
    int b = int.Parse(Console.ReadLine()!);
    if (b>0)count++;
}
Console.WriteLine($"{count} number > 0");