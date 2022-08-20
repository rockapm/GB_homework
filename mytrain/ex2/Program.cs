//9. Напишите программу которая выводит случайное число из отрезка [10 ,99] и показывает наибольшую цифру числа.
// 78 > 8
// 12 > 2
// 85 > 8

int value = new Random().Next(10, 100);
int a = value / 10;
int b = value % 10;
int big = 0;
if (a > b)
{
    big = a;
}
else
{
    big = b;
}

Console.WriteLine("Value: " + value + ", big: " + big);


void Ex01()
{
    int value = new Random().Next(10, 100);
    int a = value / 10;
    int b = value % 10;
    int big = 0;
    if (a > b)
    {
        big = a;
    }
    else
    {
        big = b;
    }

    Console.WriteLine("Value: " + value + ", big: " + big);
}


int Ex02()
{
    int value = new Random().Next(10, 100);
    int a = value / 10;
    int b = value % 10;
    int big = 0;
    if (a > b)
    {
        big = a;
        return a;
    }
    else
    {
        big = b;
        return b;
    }

    //Console.WriteLine("Value: " + value + ", big: " + big);
}

Console.WriteLine(Ex02());



string Ex03()
{
    string res = String.Empty;
    int value = new Random().Next(10, 100);
    int a = value / 10;
    int b = value % 10;
    int big = 0;
    res = Convert.ToString(value);
    if (a > b)
    {
        res = res + "   " + Convert.ToString(a);
    }
    else
    {
        res = res + "   " + Convert.ToString(b);
    }
    return res;
    //System.Console.WriteLine("Value: " + value + ", big: " + big);
}

System.Console.WriteLine(">>" + Ex03());


int Ex04(int value)
{
    int a = value / 10;
    int b = value % 10;
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

int num = new Random().Next(10, 100);
Console.WriteLine(num);


System.Console.WriteLine(Ex04(num));