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

            Console.WriteLine("Фильм какого жанра, вы бы хотели посмотреть: комедия, фантастика?");
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("В таком случае рекомендуем вам следующие фильмы:");
                Console.WriteLine("* Люди Икс");
                Console.WriteLine("* Гарри Поттер");
            }

            Console.ReadLine();
        }
    }
}
