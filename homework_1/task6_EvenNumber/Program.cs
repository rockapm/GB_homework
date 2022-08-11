Console.WriteLine("Simple program to determine the parity of a number.");
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0) { Console.WriteLine("Even (true)"); }
else { Console.WriteLine("Uneven (false)"); }

Console.Write("---end---");