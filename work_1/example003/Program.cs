//Находим в массиве индекс равный find и завершаем программу
int[] array = { 11, 12, 13, 4, 18, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}