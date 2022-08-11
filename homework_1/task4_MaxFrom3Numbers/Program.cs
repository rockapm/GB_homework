Console.WriteLine("Simple program to find maximum of three numbers.");
Console.Write("Enter 'a': ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 'b': ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 'c': ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (max < b) { max = b; }
if (max < c) { max = c; }

Console.Write("Max number: ");
Console.WriteLine(max);
Console.Write("---end---");