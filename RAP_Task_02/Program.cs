using System;

namespace RAP_Task_02
{
    class Program

    {

        static void Main(string[] args)

        {

            string exit_Word;//переменная для чтения текста

            Console.WriteLine("Данная программа выполняется пока вы не введёте слово 'exit'");

            do//цикл

            {

                Console.WriteLine(">");

                exit_Word = Convert.ToString(Console.ReadLine());

            } while (exit_Word != "exit");//условие завершения - пользователь ввёл exit

            Console.WriteLine('\n');

            Console.WriteLine("Завершение программы...");

        }
    }
}
