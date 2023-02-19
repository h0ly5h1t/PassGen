using System;

namespace PasswGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину пароля:");
            try
            {
                int symCount = int.Parse(Console.ReadLine());
                // Проверка длины пароля
                if (symCount < 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Минимальная длина пароля - 8 символов!");
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine($"Ваш пароль - \u001b[32;1m{GeneratePassword(symCount)}\u001b[0m\nДлина пароля - {symCount}");
                        Console.WriteLine("Закройте программу или нажмите любую клавишу, чтобы сгенерировать новый пароль!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Пошел вон отсюда, кыш негодяй! Не балуйся!");
            }
        }

        static string GeneratePassword(int symCount)
        {
            string password = "";
            Random rnd = new Random();
            char[] charList ={'A','a','B','b','C','c','D','d','E','e','F','f','G','g','H','h','I',
            'i','J','j','K','k','L','l','M','m','N','n','O','o','P','p','Q','q','R','r','S','s',
            'T','t','U','u','V','v','W','w','X','x','Y','y','Z','z','1','2','3','4','5','6','7',
            '8','9','&', '@', '#', '$', '%', '^', '*', '(', ')', '!', '|', '+', '-', ':', '/',
            '.', ';', '`', '~'};
            // Цикл добавления в пароль ,по заданной длине, символов из массива
            for (int i = 0; i < symCount; i++)
            {
                password += charList[rnd.Next(0, charList.Length - 1)];
            }
            return password;
        }
    }
}
