
double CalculateFormula(int a, int b, int c, int d)
{
    double num = a * b;
    int denum = c + d;
    double result = num / denum;
    return result;
}
double result=CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);