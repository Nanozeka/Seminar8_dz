//Задача 58: Задайте две матрицы. Напишите программу,
//которая будет находить произведение двух матриц.
//
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] firstMatrix = GetMatrix();
int[,] secondMatrix = GetMatrix();

int[,] GetMatrix()
{
	int[,] matrix = new int[2, 2];
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

int[,] SortMatrix()
{
	int[,] resultMatrix = new int[2, 2];
	
	resultMatrix[0, 0] = firstMatrix[0, 0] * secondMatrix[0, 0] + firstMatrix[0, 1] * secondMatrix[1, 0];
	resultMatrix[1, 0] = firstMatrix[1, 0] * secondMatrix[0, 0] + firstMatrix[1, 1] * secondMatrix[1, 0];
	resultMatrix[0, 1] = firstMatrix[0, 0] * secondMatrix[0, 1] + firstMatrix[0, 1] * secondMatrix[1, 1];
	resultMatrix[1, 1] = firstMatrix[1, 0] * secondMatrix[0, 1] + firstMatrix[1, 1] * secondMatrix[1, 1];

	return resultMatrix;
}

Console.WriteLine("Первая рандомная матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая рандомная матрица:");
PrintMatrix(secondMatrix);
Console.WriteLine();
Console.WriteLine("Результат произведения матриц:");
PrintMatrix(SortMatrix());