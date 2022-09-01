// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//ПРАВИЛЬНЫЙ ВАРИАНТ РЕШЕНИЯ

double[,] CreateTDArray(int m, int n)
{
    if (m == null || n == null)
    {
        m = 0;
        n = 0;
    }
    double[,] arr = new double[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double x = new Random().Next(100) / 10.0;
            arr[i, j] = x;
        }
        Console.WriteLine();
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}


System.Console.WriteLine("Enter rows count: ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Enter columns count: ");
int n = Convert.ToInt32(System.Console.ReadLine());
PrintArray(CreateTDArray(m, n));