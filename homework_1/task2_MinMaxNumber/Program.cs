Console.WriteLine("Simple program to find maximum of two numbers.");
Console.Write("Enter 'a': ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 'b': ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a < b) { max = b; }

Console.WriteL("Max number: ");
Console.WriteLine(max);
Console.Write("---end---");