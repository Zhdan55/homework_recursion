//Напишите программу,которая на вход принимает два числа и выводит, какое число большее, а какое меньшее.

System.Console.Write("Введите первое число:  ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число:  ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < secondNumber)
{
    System.Console.WriteLine("второе число больше");
}
if (firstNumber > secondNumber)
{
    System.Console.Write("первое число больше");
}
else
{
    System.Console.WriteLine("числа равны");
}
