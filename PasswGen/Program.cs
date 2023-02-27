using System;

namespace Password_Generator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool passTrue = true;
            Console.WriteLine("Введите длину пароля:");
            int.TryParse(Console.ReadLine(), out int symCount);
            while (passTrue)
            {
                if (symCount < 8)
                {
                    Console.WriteLine("Минимальная длина пароля составляет - 8 символов!");
                    Console.ReadKey();
                    passTrue = false;
                }
                else
                {
                    Console.WriteLine($"Ваш пароль - \u001b[32;1m{GeneratePassword(symCount)}\u001b[0m\nДлина пароля - {symCount}");
                    Console.WriteLine("Закройте программу или нажмите любую клавишу, чтобы сгенерировать новый пароль!");
                    Console.ReadKey();
                    Console.Clear();
                }

            }

        }

        private static string GeneratePassword(int symCount)
        {
            string password = "";
            Random randomChars = new Random();

            char[] charList ={'A','a','B','b','C','c','D','d','E','e','F','f','G','g','H','h','I',
            'i','J','j','K','k','L','l','M','m','N','n','O','o','P','p','Q','q','R','r','S','s',
            'T','t','U','u','V','v','W','w','X','x','Y','y','Z','z','1','2','3','4','5','6','7',
            '8','9','&', '@', '#', '$', '%', '^', '*', '(', ')', '!', '|', '+', '-', ':', '/',
            '.', ';', '`', '~'};

            for (int i = 0; i < symCount; i++)
                password += charList[randomChars.Next(0, charList.Length)];

            return password;
        }
    }
}
