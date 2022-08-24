// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void CreateArray(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(1, 100);
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

int DiffMinMax(int[] array, out int min, out int max)  // ищем макс и мин число в массиве, их разницу, а так же (спасибо гугл) удалось сделать возврат нескольких переменных (out min, out max)
{
    int length = array.Length;
    min = array[0];
    max = array[0];
    int diff = 0;
    for (int i = 0; i < length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    diff = max - min;
    return diff;
}



void Task38()
{
    Console.WriteLine("----START----");
    Console.WriteLine();
    Console.WriteLine("---TASK 38---");
    Console.WriteLine();
    int[] array = new int[10];  //получаем размер массива 

    CreateArray(array);   //создаем массив
    PrintArray(array);    //печатаем массив
    int diff = DiffMinMax(array, out int min, out int max);   // присваивем переменной то что она возвращает через return, а так же указываем что так же получим мин и макс
    Console.WriteLine($"min: {min}, max: {max}");  //полученные выше мин и макс выводим в консоль
    Console.WriteLine("Difference: " + diff);
    Console.WriteLine();
    Console.WriteLine("-----END-----");
}

Task38();