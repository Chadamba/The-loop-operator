using System;
class MainClass
{
    private static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( "МЕНЮ:" +
                "\n" +
                "\n Выберите пункт из списка.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n 1 - Таблица умножения от 1 до 10" +
                "\n 2 - Делители" +
                "\n 3 - Условие кратности" +
                "\n 4 - Произведение чётных чисел");
            Console.ResetColor();

            int userСhoice = GetInt(nameof(userСhoice));
            if (userСhoice == 1)
            {
                MultiplicationTableFromOneToTen();
            }
            else if (userСhoice == 2)
            {
                Divisors();
            }
            else if (userСhoice == 3)
            {
                MultiplicityCondition();
            }
            else if (userСhoice == 4)
            {
                ProductOfEvenNumbers();
            }
            else if (userСhoice >= 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Несуществующий пункт");
            }
            Console.ResetColor();
        }

    }

    private static int GetInt(string name)
    {
        bool check;
        int number;
        do
        {
            check = int.TryParse(Console.ReadLine(), out number);
            if (!check)
            {
                
                Console.WriteLine("Вы ввели неправильное значение." +
                "\n Введите правильное значение =" + name + ".");
                
            }
        }
        while (!check);
        return number;
    }

    private static void MultiplicationTableFromOneToTen()
    {
        Console.WriteLine("Таблица умножение введеного число от 1 до 10");
        Console.Write("Введите число = ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("НАЖМИТЕ ЛЮБУЮ КНОПКУ ЧТО-БЫ ВЕРНУТСЯ В МЕНЮ");
        Console.ReadLine();
        Console.ResetColor();

    }

    private static void Divisors()
    {
        Console.WriteLine("В данно пунтке Делители" +
            "\nрассчитывается количество делителей введеного числа" +
            "\nи выводится одно число - общее количество делителей");

        Console.Write("Введите число = ");
        int number = Convert.ToInt32(Console.ReadLine());
        int n;
        int numberOfDivisors = 0;

        for (int i = 1; i <= number; i++) 
        {
            if (number % i == 0)
            {
                numberOfDivisors++;
            }
        }

        Console.WriteLine($"Общее количество делителей введеного числа = {numberOfDivisors}");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("НАЖМИТЕ ЛЮБУЮ КНОПКУ ЧТО-БЫ ВЕРНУТСЯ В МЕНЮ");
        Console.ReadLine();
        Console.ResetColor();
    }

    private static void MultiplicityCondition() 
    {
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("\n В данно пунтке Условие кратности" +
            "\n находим все числа от 1 до введеного числа " +
            "\n которые кратны второму введеному числу" +
            "\n и не кратны третьему введеному числу");
        Console.WriteLine();
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" Введите число = ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Кратному = ");
        int multiple = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Не кратному = ");
        int notMultiple = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.ResetColor();

        for (int i = 1; i <= number; i++)
        {
            if (i % multiple == 0 && i % notMultiple !=0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" Число подходит к условию = {i}");
                Console.ResetColor();
            }
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" НАЖМИТЕ ЛЮБУЮ КНОПКУ ЧТО-БЫ ВЕРНУТСЯ В МЕНЮ");
        Console.ReadLine();
        Console.ResetColor();
    }

    private static void ProductOfEvenNumbers()
    {
        int n = int.Parse(Console.ReadLine());
        int mult = 1;

        for (int i = 2; i <= n; i = i + 2)
        {
            mult *= i;
        }
        Console.Write(mult);
    }
}
