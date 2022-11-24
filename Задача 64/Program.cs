// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string Numbers( int num)
{ 
    if(num == 1) 
    {
        return num.ToString();
    }

    return num + ", " + Numbers(num - 1);
}
Console.Clear();
int n = int.Parse(Console.ReadLine()!);
Console.Write( $"{n} -> \"");
Console.Write(Numbers (n));
Console.Write("\"");