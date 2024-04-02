// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

void Main()
{
System.Console.Write("Введите строку: ");
string? str = Console.ReadLine();

// char[] c = str!.ToCharArray();
// PrintArray(c);

char[] chars = StringToCharArray(str);
PrintArray(chars);
}

char[] StringToCharArray(string? str)
{
char[] tempChars = new char[str!.Length];

for(int i = 0; i < tempChars.Length; i++)
tempChars[i] = str[i];

return tempChars;
}

void PrintArray(char[] chars)
{
System.Console.WriteLine("['" + string.Join("', '", chars) + "']");
}

Main();