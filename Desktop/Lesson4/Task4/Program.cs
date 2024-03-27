// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.


void Main()
{
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");

int[,] matrix = GenerateMatrix(rows, cols, 0, 9);

PrintMatrix(matrix);

PrintArray(FindRowAverages(matrix));
}

void PrintArray(double[] array)
{
System.Console.WriteLine(string.Join(", ", array));
}

double[] FindRowAverages(int[,] matrix)
{
double[] averages = new double[matrix.GetLength(0)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
averages[i] += matrix[i, j];
}

averages[i] = Math.Round(averages[i] / matrix.GetLength(1), 2);
}

return averages;
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