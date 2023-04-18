using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер дня в году (1-365): ");
        int dayNum = int.Parse(Console.ReadLine());

        int dayOfWeek = (dayNum + 5) % 7;

        if (dayOfWeek == 0)
        {
            dayOfWeek = 7;
        }

        Console.WriteLine("Номер дня недели: " + dayOfWeek);

        Console.ReadKey();
    }
}
