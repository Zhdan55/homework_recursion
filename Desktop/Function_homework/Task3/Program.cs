//Напишите программу, 
//которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
public class Example
{
    public static void Main()
    {
        int[] array = { 2, 4, 6, 8 };
        Array.Reverse(array);
 
        Console.WriteLine(String.Join(',', array));
    }
}