/*
    Задача 64: Задайте значение N. Напишите программу, которая выведет все 
    натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

Console.WriteLine("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine()!);

string NaturalNumbersFromNTo1(int n, int m)
{
    m = 1;
    if (n < m)
    {
        return $"{n} не натуральное число";
    }
    if (n == m)
    {
        return $"{n}";
    }
    return n + ", " + NaturalNumbersFromNTo1(n - 1, m);
}

Console.WriteLine(NaturalNumbersFromNTo1(n, 1));