// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
void Main ()
    {   
        int m = ReadInt("Введите число m: ");
        int n = ReadInt("Введите число n: ");
        PrintNaturalNumbers(m,n);
    }

    int PrintNaturalNumbers(int m,int n);
    if (m == 0) 
    {
        return n+1;
    }
    if ((m > 0) && (n == 0))
    {
        return (m-1,1);
    }
    if ((m > 0) && (n > 0))
    {
        return (m - 1) && (m,n - 1);
    }

int ReadInt (string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();