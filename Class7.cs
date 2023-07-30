using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class Class7
    {
        public void Less10()
        {
            bool[] thimble = { false, false, true};

            Console.WriteLine("Игра в наперстки");
            Console.WriteLine();
            Console.WriteLine("под одним из трех наперстков находится шарик. Попробуйте угадать в каком!");
            Console.WriteLine();
            Console.Write("Введите ваше число от 1 до 3: ");
            int input = Convert.ToInt32(Console.ReadLine());

            input--;

            if (input < thimble.Length && thimble[input])
            {
                Console.WriteLine("Да! Вы нашли шарик!");
            }
            else
            {
                Console.WriteLine("Нет! Вы не угадали!");
            }
        }
    }
}
