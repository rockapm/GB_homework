// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void PrintNaturalNum(int m, int n)
{
    int m2 = m;
    for (int i = 0; i <= n - m; i++)
    {
        Console.Write(m2);
        if (m2 != n) Console.Write(", ");
    }
}

PrintNaturalNum(1, 10);