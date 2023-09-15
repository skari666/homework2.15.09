using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;

        Console.WriteLine($"Теперь первое число равно {firstNumber}, а второе равно {secondNumber}");
    }
}
