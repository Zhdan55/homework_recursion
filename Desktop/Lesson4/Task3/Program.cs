// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

void Main()
{
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");

int[,] matrix = GenerateMatrix(rows, cols, 0, 9);

PrintMatrix(matrix);

System.Console.WriteLine(FindSumOnDiagonal(matrix));
}

int FindSumOnDiagonal(int[,] matrix)
{
int sum = 0;

for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
{
sum += matrix[i, i];
}

return sum;
}

void PrintMatrix(int[,] arrayForPrint)
{
for (int i = 0; i < arrayForPrint.GetLength(0); i++)
{
for (int j = 0; j < arrayForPrint.GetLength(1); j++)
{
System.Console.Write(arrayForPrint[i, j] + "\t");
}
System.Console.WriteLine();
}

System.Console.WriteLine();
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
int[,] tempMatrix = new int[row, col];
Random rand = new Random();

for (int i = 0; i < row; i++)
{
for (int j = 0; j < col; j++)
{
tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
}
}

return tempMatrix;
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}

Main();