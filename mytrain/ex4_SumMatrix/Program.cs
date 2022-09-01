//Задача n: Написать программу, которая будет искать сумму матриц при их одинаковой длине    
    
    string matrix1 = "1, 4, 12, 6, 5";
		string matrix2 = "3, 2, 16, 7, 2";
		
		
		int[] StrToInt(string arr)  //Convert String array to integer array
		{
			arr = arr.Replace(" ", "");
		    string[] sarr = arr.Split(",");
		    int[] iarr = Array.ConvertAll(sarr, int.Parse);
			return iarr;
		}
		
		int[] SumMatrix(int[] m1, int[] m2)  //Sum m1 + m2
		{
			int[] sum = new int[m1.Length];
			for  (int i = 0; i < m1.Length; i++)
			{
				sum[i] = m1[i] + m2[i];
			}
			return sum;
		}
		
		void PrintResult(int[] sum)  // Print result of sum
		{
			Console.WriteLine("Sum of matrix:");
			for (int i = 0; i < sum.Length; i++)
			{
				Console.Write(sum[i] + ", ");
			}
		}
				
		int[] mat1 = StrToInt(matrix1);
		int[] mat2 = StrToInt(matrix2);
		
		if (mat1.Length == mat2.Length) SumMatrix(mat1, mat2);
		else Console.WriteLine("ERROR! Length m1 != m2");
	
		PrintResult(SumMatrix(mat1, mat2));
