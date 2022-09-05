
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


//Образец с интернета. Надо долделать и разобраться

int[,] mas = new int[3,5] {{1,2,3,2,3},{3,5,7,2,3},{5,6,1,2,3}};
 
for (int i = 0; i < mas.GetLength(1); i++) 
{
    int srAr = 0;
    int ColChetn = 0;
    for (int t = 0; t < mas.GetLength(0); t++)
    {
        srAr += mas[t, i];
        ColChetn += (mas[t, i] % 2 == 0) ? 1 : 0;
    }
    Console.WriteLine($"Srednee arifm stolbca {i + 1} = {(float)srAr/3}");
    Console.WriteLine($"Kol-vo chetnix stolbcov {i + 1} = {ColChetn}");
}
