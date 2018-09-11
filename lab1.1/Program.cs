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
        }
    }
}
