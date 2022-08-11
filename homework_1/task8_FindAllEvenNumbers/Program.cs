Console.WriteLine("Simple program to find all parity numbers.");
Console.WriteLine("Enter number: ");
int a = 1;
int b = Convert.ToInt32(Console.ReadLine());

for (int i = a; i <= b; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
}


Console.Write("; end");