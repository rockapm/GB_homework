// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateTDArray(int row, int col)
{
    int s = 0;
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            s = s + 1;
            arr[i, j] = new Random().Next(0, 10);

        }
    }
    return arr;
}

int[] SumColumns(int[,] arr)
{
    int[] sumCol = new int[arr.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
        }
        sumCol[i] = sum;
    }
    return sumCol;
}

float[] AverageCol(int[] arr, int[,] arr2)
{
    float[] aver = new float[arr.Length];
    //int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        aver[i] = (float)arr[i] / arr2.GetLength(0);
    }
    return aver;
}


void PrintTDArray(int[,] arr)
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


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}  ");
        //System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintFloatArray(float[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}  ");
        //System.Console.WriteLine();
    }
    System.Console.WriteLine();
}




int[,] arr = CreateTDArray(3, 2);
int[] sum = SumColumns(arr);
PrintTDArray(arr);
System.Console.WriteLine();
PrintArray(sum);
PrintFloatArray(AverageCol(sum, arr));