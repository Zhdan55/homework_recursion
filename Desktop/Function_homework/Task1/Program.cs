//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

tring input = " ";
    int num;
    bool exit = true;
    while (exit)
    {
        input = Input();
        if (int.TryParse(input, out num))
            exit = !(num % 2 == 0);
        else
        if (input == "q")
            exit = false;
    }
    string Input()
    {
        Console.WriteLine("Введите число или символ 'q' для выхода");
        return Console.ReadLine();
    }

