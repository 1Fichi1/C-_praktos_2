using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1.Угадай число");
            Console.WriteLine("2.Таблица умножения");
            Console.WriteLine("3.Вывод делителей числа");
            Console.WriteLine("4.Выход");
            Console.Write("Выберите программу от 1 до 4: ");

            int chislo = Convert.ToInt32(Console.ReadLine());

            switch (chislo)
            {
                case 1:
                    Gadalka();
                    break;
                case 2:
                    Umnojalka();
                    break;
                case 3:
                    Ckokodelitichislo();
                    break;
                case 4:
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Пожалуйста, выберите число от 1 до 4.");
                    break;
            }
        }
    }

    static void Gadalka()
    {
        Random tutu = new Random();
        int ahalaimahalai = tutu.Next(101);
        int popitki = 0;

        Console.WriteLine("Игра: Угадай число");
        Console.WriteLine("Угадайте число от 0 до 100.");

        while (true)
        {
            Console.Write("Введите число: ");
            int mychislo = Convert.ToInt32(Console.ReadLine());
            popitki++;

            if (mychislo == ahalaimahalai)
            {
                Console.WriteLine($"Урааа! Вы угадали число {ahalaimahalai} за {popitki} попыток.");
                return;
            }
            else if (mychislo < ahalaimahalai)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        }
    }

    static void Umnojalka()
    {
        Console.WriteLine("Таблица умножения:");

        for (int a = 1; a <= 10; a++)
        {
            for (int b = 1; b <= 10; b++)
            {
                Console.Write($"{a * b,4}");
            }
            Console.WriteLine();
        }
    }

    static void Ckokodelitichislo()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Делители числа {number}:");

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}