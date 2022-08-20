// // 1 Метод который ничего не принимает и не возвращает

// void Info1()
// {
//     Console.WriteLine("Text");
// }


// // 2 метод который ничего не возвращает, но принимает

// void Logger2(string data)
// {
//     File.AppendAllText("db.csv", DateTime.Now + "; " + data + Environment.NewLine);
// }


// // 3 метод который ничего не принимает, но возвращает

// int GetRandom3()
// {
//     return new Random().Next(1, 10);
// }


// // 4 метод который возвращает и принимает

// int GetRandom4(int min, int max)
// {
//     return new Random().Next(min, max);
// }


// int ProxyDoIt(int uptime, bool flag, int minValue, int maxValue)
// {
//     int num = 0;
//     if (flag) num = GetRandom4(minValue, maxValue);
//     else num = GetRandom3();
//     string s = Convert.ToString(num);
//     Logger2(s);
//     Thread.Sleep(new Random().Next(2000, 2000 + uptime));
//     return num;
// }

// Info1();
// Console.WriteLine(ProxyDoIt(1000, true, 10, 100));
// Console.WriteLine(ProxyDoIt(1000, !true, 1000, 100));
// Console.WriteLine(ProxyDoIt(1000, true, 2000, 10000));


// Console.WriteLine("return 0");