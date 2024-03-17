// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

void Main()
{
    int sizeArray = ReadInt("Введите размер массива (не больше 8): ");

    if (sizeArray > 8 || sizeArray < 0)
    {
        System.Console.WriteLine("Вы ввели некорректный размер массива!");
        return;
    }

    int[] array = GenerateArray(sizeArray, 0, 9);
    PrintArray(array);


    System.Console.WriteLine("\n" + FromArrayToNumber(array));
}

// int FromArrayToNumber(int[] array)
// {
//     int mult = (int)Math.Pow(10, array.Length - 1);
//     int expectedNumber = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         expectedNumber += array[i] * mult;
//         mult /= 10;
//     }

//     return expectedNumber;
// }

int FromArrayToNumber(int[] array)
{
    return Convert.ToInt32(string.Concat(array)); // {1, 5, 4, 3} -> "1543"
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1); // Next(0, 99 + 1)

    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    // foreach (int number in arrayForPrint)
    // {
    //     System.Console.Write(number + " ");
    // }

    System.Console.WriteLine("[ " + string.Join(", ", arrayForPrint) + " ]");
}

// --------------- ОСНОВНАЯ ЧАСТЬ КОДА ------------------
Main();