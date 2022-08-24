// Задача: удалить все гласные из вводимого текста
using System.Text.RegularExpressions;

string Disemvowel(string str)
{
    string str1 = str;
    string str2 = Regex.Replace(str1, "[AaEeIiOoUu]", "");

    return str2;
}

Console.WriteLine("Enter text:");
string str = Console.ReadLine();
Console.WriteLine(Disemvowel(str));

