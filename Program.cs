//№1

// Console.WriteLine("Количество строк: ");
// int s = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Количество столбцов: ");
// int c = Convert.ToInt32(Console.ReadLine());
/*
double[,] Array = new double[3,4];
for (int i = 0; i < Array.GetLength(0); i++)
{
	for (int j = 0; j < Array.GetLength(1); j++)
	{
		Array[i,j]= Math.Round(new Random().NextDouble()*100,2);
	}
}
for (int k = 0; k < Array.GetLength(0); k++)
{
	for (int m = 0; m < Array.GetLength(1); m++)
	{
		Console.Write(Array[k,m] + "\t");
	}
	Console.WriteLine();
}
*/


//#2
/*
Console.WriteLine("Номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5, 10];
for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		matrix[i, j] = new Random().Next(11);
	}
}
for (int k = 0; k < matrix.GetLength(0); k++)
{
	for (int m = 0; m < matrix.GetLength(1); m++)
	{
		Console.Write(matrix[k, m] + "\t");
	}
	Console.WriteLine();
}
Console.WriteLine((rows > matrix.GetLength(0) || columns > matrix.GetLength(1)) ? 
$"За пределами массива" : $"Выбранное число -  {matrix[rows - 1, columns - 1]}");
*/

//#3

int[,] matrix = new int[5, 10];

for (int i = 0; i < matrix.GetLength(1); i++)
{
	double sum=0;
	for (int j = 0; j < matrix.GetLength(0); j++)
	{
		matrix[j, i] = new Random().Next(11);
		sum+=matrix[j, i];
	}
Console.WriteLine($"Среднее арифметическое столбца {i}\t{sum/5}");
}
for (int k = 0; k < matrix.GetLength(0); k++)
{
	for (int m = 0; m < matrix.GetLength(1); m++)
	{
		Console.Write(matrix[k, m] + "\t");
	}
	Console.WriteLine();
}

