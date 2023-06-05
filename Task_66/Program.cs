/*
    Задача 66: Задайте значения M и N. Напишите программу, 
    которая найдёт сумму натуральных элементов в промежутке от M до N.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

Console.Clear();

Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

int SumOfNaturalNumbers(int m, int n)
{
    int sum = 0;
    if(m < n)
    {
        sum = m + n + SumOfNaturalNumbers(m + 1, n - 1);
    }
    else if(m == n) 
    {
        sum = n;
    }
    return sum;
}

Console.WriteLine($"M = {m}; N = {n} -> {SumOfNaturalNumbers(m, n)}");