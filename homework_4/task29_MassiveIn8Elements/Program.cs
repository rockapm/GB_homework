// Задача 29: Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.
// пример вывода
// [1,4,5,3,1,2,3,9]
// [4,45,53,31,14,25,63,19]

void CreateMassive(int[] mass)   //функция создания массива
{
    int length = mass.Length;     //длина массива которую мы должны принять
    int index = 0;
    while (index < length)
    {
        mass[index] = new Random().Next(1, 101);
        index++;
    }
}

void PrintMassive(int[] mass_)     //выводит получившийся массив в консоль
{
    int length = mass_.Length;     //длина массива которую примем
    int count = 0;
    while (count < length)
    {
        if (count == 0) Console.Write("Array of " + mass_.Length + " numbers = [");    //красивое оформление вывода
        Console.Write(mass_[count]);
        if (count < length - 1) Console.Write(", ");
        else Console.WriteLine("]");
        count++;
    }
}

int[] mass = new int[8];
CreateMassive(mass);
PrintMassive(mass);
