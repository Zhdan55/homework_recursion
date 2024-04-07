// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, 
//не использовать циклы.

void Main()
{ 
    int[] array = GenerateArray(10, 1, 10);
    Printntarray(array, 10);
    System.Console.WriteLine(".");
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
} 

void Printntarray(int[] temparray, int rightRange)
{
    if(rightRange >= 1)
    {
        System.Console.Write(temparray[rightRange-1]+ " ");
        Printntarray(temparray, rightRange -= 1);
    }
     
}



int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    tempArray[i] = rand.Next(leftRange, rightRange + 1); 
    return tempArray;
}
Main();