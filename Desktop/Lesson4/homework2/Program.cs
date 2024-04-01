//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
void Main()
{
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = GenerateMatrix(rows, cols, 0, 9);

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

PrintMatrix(matrix);

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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (i > 0 && i < array.GetLength(1))
            {
                int temporary = array[i, j];
                array[i, j] = array[i, j];
                array[i, j] = temporary;
            }
            else
            {
                int temporary = array[i, j];
                array[i, j] = array[(array.GetLength(1) - 1), j];
                array[(array.GetLength(1) - 1), j] = temporary;
            }
        }
    }
}
ChangeArray(array);
PrintMatrix(array);
















}
Main();