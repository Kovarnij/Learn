using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class Class6
    {
        public void Less9()
        {
            int magicNumber = 4;

            Console.WriteLine("Угадай число");
            Console.WriteLine();
            Console.WriteLine("Загадано число от 1 до 5. Попробуйте его отгадать!");
            Console.WriteLine();
            Console.Write("Введите ваше число: ");
            int input = Convert.ToInt32(Console.ReadLine());

            //

            if (input == magicNumber)
            {
                Console.WriteLine("Да! Это число " + magicNumber + "!");
            }
            else
            {                
                Console.WriteLine("Нет! Это не " + input + "!");
            }
        }
    }
}
