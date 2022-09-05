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
 
            for(int i = 0; i < arr.GetLength(0); i++) //Проходим по циклу строк
            {
                Sum2 = 0;
                for(int j = 0; j < arr.GetLength(1); j++) //Проходим по циклу столбцов
                {   
					Sum2 += arr[i, j];  //Сумма всех членов 1ой строки
				} 
				Console.WriteLine($"Sum Row {i + 1} = {Sum2 }");
                if(Sum2 < Sum1)
                {   
					Sum = Sum2; 
					Row = i + 1;    
				}
                Sum1 = Sum2;
            }
			Console.WriteLine($"Min Row Number = {Row}");
		}
		
		int[,] array = CreateTDArray(5,3);
		PrintArray(array);
		FindMinSumRow(array);
