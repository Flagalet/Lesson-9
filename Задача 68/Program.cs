// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return GetAckerman(m - 1, 1);
    if (m > 0 && n > 0) return GetAckerman(m - 1, GetAckerman(m, n - 1));
    return m;
}
Console.Clear();
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {GetAckerman(m, n)}");