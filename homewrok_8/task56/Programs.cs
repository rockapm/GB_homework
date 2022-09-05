		int[,] CreateTDArray(int rows, int columns)
		{
			int r = rows;
			int c = columns;
			int[,] arr = new int[r, c];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = new Random().Next(0,10);
				}
			}
			return arr;			
		}
		
		
		
		void PrintArray(int[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					System.Console.Write($"{arr[i, j]}  ");
				}
				System.Console.WriteLine();
			}
		}
		
		void FindMinSumRow(int[,] arr)
		{
			int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
			int sumrow = 0;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				int minrow = 0;
				sumrow = 0;
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					sumrow += arr[i,j];
				}
				Console.WriteLine($"Sum Row {i + 1} = {sumrow}");
				
				
				if(sumrow < Sum1)
                {   
					Sum = sumrow; 
					Row = i;    
				}
                Sum1 = Sum2;
				
			}
			Console.WriteLine($"Min Row Number = {Row}");
		}
		
		int[,] array = CreateTDArray(5,3);
		PrintArray(array);
		FindMinSumRow(array);
