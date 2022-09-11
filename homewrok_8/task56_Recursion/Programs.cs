//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//
//M = 4; N = 8. -> ""4, 6, 7, 8""

int count = 0;
        void FindNum(int m, int n)
        {
            count++;
            int z = 1;
            System.Console.WriteLine();
            if (m != n)
            {
            if (m > n)
            {
                z=-1;
            }
            if (m < n)
            {
                z=1;
            }
                System.Console.Write(count + ") " + m);
                FindNum(m+z,n);
            }
            
        }
        
        FindNum(15,25);
