// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void CreateArray(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arr_)
{
    int len_ = arr_.Length;
    for (int i = 0; i < len_; i++)
    {
        if (i == 0) Console.Write("Your array of " + arr_.Length + " numbers = [");
        Console.Write(arr_[i]);
        if (i < len_ - 1) Console.Write(", ");
        else Console.WriteLine("]");
    }
}

int PositiveNumbers(int[] arr__)
{
    int len__ = arr__.Length;
    int count = 0;
    for (int i = 0; i < len__; i++)
    {
        if (arr__[i] % 2 == 0) count = count + 1;
    }
    return count;
}




Console.WriteLine("----START----");
Console.Write("Enter length of array: ");

int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];  //получаем размер массива 

CreateArray(arr);   //создаем массив
PrintArray(arr);    //печатаем массив
int count = PositiveNumbers(arr);   // присваиваем переменной количество положительных чисел в массиве

Console.WriteLine("Count of positive numbers: " + count);
Console.WriteLine("-----END-----");