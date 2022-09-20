// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string text;
int countLetters;

string[] FirstArray(string str)  //преобразуем введенный текст в массив
{
    string[] arr = str.Split(',');
    return arr;
}

void PrintArray(string[] arr)  //печатаем полный массив убрав лишние пробелы
{
    string s;
    int ii;
    Console.Write("Your words: ");
    for (int i = 0; i < arr.Length; i++)
    {
        s = arr[i];
        ii = i + 1;
        System.Console.Write(s.Trim());
        if (ii < arr.Length) System.Console.Write(", ");
    }
    System.Console.WriteLine();
}

void FilterArray(string[] arr)  //фильтруем слова по количеству букв countLetters
{
    //string[] res = new string[];
    string s;
    int ii;
    System.Console.Write($"Words shorter/equal than {countLetters} letters: ");
    for (int i = 0; i < arr.Length; i++)
    {
        s = arr[i].Trim();
        ii = i + 1;
        if (s.Length <= countLetters)
        {
            Console.Write(s);
            if (ii < arr.Length) { System.Console.Write(", "); }
        }
    }
    System.Console.WriteLine();
}

void StartProgram() 
{
    System.Console.WriteLine("---------------------------------");
    System.Console.WriteLine("---Enter text separated by commas:");
    text = System.Console.ReadLine();
    System.Console.WriteLine("---Enter the number of characters to filter text:");
    countLetters = Convert.ToInt32(System.Console.ReadLine());
    System.Console.WriteLine("---Result:");

    PrintArray(FirstArray(text));
    FilterArray(FirstArray(text));
    System.Console.WriteLine("--------------end----------------");
}

StartProgram();