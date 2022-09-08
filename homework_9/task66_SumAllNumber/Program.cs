// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void PrintSumNaturalNum(int m, int n)
{
    int m2 = m;
    int sum = 0;
    for (int i = 0; i <= n - m; i++)
    {
        sum += m2;
        Console.Write(m2);
        if (m2 != n) Console.Write(" + ");
        m2 = m2 + 1;
    }
    Console.WriteLine(" = " + sum);
}

PrintSumNaturalNum(1, 5);