// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int Recursiv(int N, int M)
{
    int sum = 0;
    if (N == M) return N;
    else
    {
        return sum = N + Recursiv(N + 1, M);
    }
}

Console.Clear();
Console.WriteLine("Введите число от: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число до: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(Recursiv(N, M));