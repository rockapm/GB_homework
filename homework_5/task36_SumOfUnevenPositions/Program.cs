// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void CreateArray(int[] arr, int a, int b)   //создаем массив, принимая размер массива, мин и макс рандома
{
    int len = arr.Length;
    int min = a;
    int max = b;
    for (int i = 0; i < len; i++)
    {
        if (max > min)
        {
            arr[i] = new Random().Next(min, max);
        }
        else
        {
            arr[i] = new Random().Next(1, 1);
        }
    }
}

void PrintArray(int[] arr_)  //печатаем массив в консоль
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

int FindSum(int[] arr__)  //ищем сумму нечетных позиций и возвращаем ее
{
    int len__ = arr__.Length;
    int sum_ = 0;
    for (int i = 0; i < len__; i++)
    {
        if (i % 2 != 0)
        {
            sum_ = sum_ + arr__[i];
        }
    }
    return sum_;
}

void PrintUnevenPos(int[] array_, int summary)  //печатаем в консоль кол-во нечетных позиций, их перечисление в виде уравнения и сумму полученную из FindSum()
{
    int length_ = array_.Length;
    int count = 0;
    int sum = summary;
    Console.Write("SUMMARY of uneven pos: ");
    for (int i = 0; i < length_; i++)
    {
        if (i % 2 != 0)
        {
            count = count + 1;
            Console.Write(array_[i]);
            if (i < length_ - 2) Console.Write(" + ");
        }
        else
        {
        }
    }
    Console.WriteLine(" = " + sum);
    Console.Write("COUNT of uneven pos: " + count);

}

void Task36()
{
    Console.WriteLine("----START----");
    Console.WriteLine();
    Console.WriteLine("---TASK 36---");
    Console.WriteLine();

    Console.Write("Enter length of array: ");   //вводим длину массива
    int len = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter max random value: ");   //вводим макс рандомизатора
    int b = Convert.ToInt32(Console.ReadLine());
    int a = 1;

    if (b > a)  // если максимум рандомизатора больше минимума то продолжаем
    {
        int[] array = new int[len];
        CreateArray(array, a, b);
        Console.WriteLine();
        PrintArray(array);
        int sum = FindSum(array);
        PrintUnevenPos(array, sum);
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("ERROR! MAX < MIN!");
    }

    Console.WriteLine();
    Console.WriteLine("-----END-----");
}

Task36();