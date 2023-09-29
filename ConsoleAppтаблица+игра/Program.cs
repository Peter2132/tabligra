using System;

class Program
{
    static void Main()
    {
        string txt;
        do
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("4. Закрыть программу");
            txt = Console.ReadLine();

            if (txt == "1")
            {
                Console.WriteLine("Угадай число");
                Random random = new Random();
                int otvet;
                int chislo = random.Next(1, 100);
                int i;
                for (i = 0; i < 100; i++)
                {
                    Console.Write("Введите число: ");
                    otvet = Convert.ToInt32(Console.ReadLine());
                    if (otvet < chislo)
                    {
                        Console.WriteLine("Число больше");
                    }
                    else if (otvet > chislo)
                    {
                        Console.WriteLine("Число меньше");
                    }
                    if (otvet == chislo)
                    {
                        Console.WriteLine("ПОбеда");
                        break;
                    }
                }
            }
            else if (txt == "2")
            {
                Console.WriteLine("Таблица умножения");
                while (true)
                {
                    int[,] tb = new int[9, 9];
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            tb[i - 1, j - 1] = i * j;
                        }
                    }

                    Console.Write("   ");
                    for (int j = 1; j <= 9; j++)
                    {
                        Console.Write($"{j,3} ");
                    }
                    Console.WriteLine("\n");

                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write($"{i + 1,2} ");
                        for (int j = 0; j < 9; j++)
                        {
                            Console.Write($"{tb[i, j],3} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\n Введите 'выход' для завершения проги");
                    string Input = Console.ReadLine();
                    if (Input == "выход")
                    {
                        break;
                    }
                }
            }
        } while (txt != "4");
    }
}
