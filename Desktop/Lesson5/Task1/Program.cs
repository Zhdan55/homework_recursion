//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: ");
    PrintNaturalNumbers(M,N);
}
void PrintNaturalNumbers(int M, int N)
{
    if (M < N + 1)
    {
        Console.Write(M +" ");
        PrintNaturalNumbers(M + 1, N);
    }
}
int ReadInt (string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();