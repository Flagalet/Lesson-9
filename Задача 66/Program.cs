// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumPrint(int m, int n)
{ 
    if(m == n) 
    {
        return m;
    }
    return m + SumPrint(m + 1, n);
}
Console.Clear();
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write($"M = {m}; N = {n} -> ");
Console.Write(SumPrint(m, n));