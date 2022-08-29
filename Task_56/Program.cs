// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new();
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0) Console.Write("[");
            if(j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, ");
            else Console.Write($"{array[i, j],3} ]");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(4,4);
PrintMatrix(matrix);
Console.WriteLine();
SumElem( matrix);

void SumElem(int[,] matrix) 
{
    int minSumRows = 0;
    int sumRows = SumRowsElements(matrix, 0);
    for (int i = 1; i <matrix.GetLength(0); i++)
    {
      int tempSumRows = SumRowsElements(matrix, i);
      if (sumRows > tempSumRows)
      {
        sumRows = tempSumRows;
        minSumRows = i;
      }
    }

    Console.WriteLine($"Номер строки с наименьшей суммой ({sumRows}) элементов -> {minSumRows+1}");
}

int SumRowsElements(int[,] array, int i)
{
  int sumRows = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRows += array[i,j];
  }
  return sumRows;
}

