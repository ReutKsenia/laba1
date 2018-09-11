using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа поможет подобрать вам фильм для вечернего просмотра.");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();

            Console.WriteLine("Здравствуйте, " + name + "!");

            Console.WriteLine("Фильм какого жанра, вы бы хотели посмотреть: комедия, фантастика, драмма, ужасы?");
            String genre = Console.ReadLine();

            if (genre == "комедия")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("В таком случае рекомендуем вам следующие фильмы:");
                Console.WriteLine("* Иван Васильевич меняет профессию");
                Console.WriteLine("* В джазе только девушки");
                Console.WriteLine("* Назад в будующее");
            }
            else if (genre == "фантастика")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("В таком случае рекомендуем вам следующие фильмы:");
                Console.WriteLine("* Люди Икс");
                Console.WriteLine("* Гарри Поттер");
            }
            else if (genre == "ужасы")
            {
                Console.WriteLine("Сколько вам лет?");
                String yearString = Console.ReadLine();
                int years = Int32.Parse(yearString);
                if (years < 18)
                {
                    Console.WriteLine("К сожалению этот жанр доступен только дляпользвателей 18+");
                    Console.WriteLine("Прходите через " + (18 - years) + " года.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("В таком случае рекомендуем вам следующие фильмы:");
                    Console.WriteLine("* Оно");
                    Console.WriteLine("* Пила 8");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("В таком случае рекомендуем вам следующие фильмы:");
                Console.WriteLine("* Зелёная миля");
                Console.WriteLine("* Побег из Шоушенка");
            }
        }
    }
}
