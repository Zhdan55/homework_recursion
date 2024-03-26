// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3 4 3 4 3
// 4 3 4 1 => 4 3 4 1
// 2 9 5 4 2 9 25 4

void Main()
{
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");

int[,] matrix = GenerateMatrix(rows, cols, 0, 9);

PrintMatrix(matrix);

ChangeMatrix(matrix);

System.Console.WriteLine();

PrintMatrix(matrix);

}

void ChangeMatrix(int[,] oldMatrix)
{
for (int i = 0; i < oldMatrix.GetLength(0); i += 2)
{
for (int j = 0; j < oldMatrix.GetLength(1); j += 2)
{
oldMatrix[i, j] *= oldMatrix[i, j];
}
}
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