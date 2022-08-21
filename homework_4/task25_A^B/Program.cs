// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// нельзя использовать pow
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

int FindDegree(int a, int b)   //принимаем а и б
{
    int result = a;
    int degree = 0;
    while (degree < b - 1)
    {
        result = result * a;  //умножаем само на себя b раз
        degree++;
    }
    return result;
}


Console.Write("Enter Number A: ");
int aa = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Degree B: ");
int bb = Convert.ToInt32(Console.ReadLine());
int res = FindDegree(aa, bb);

Console.WriteLine("A^B: " + res);