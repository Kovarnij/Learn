using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class Class5
    {
        public void Less8()
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Введите свой возраст: ");
            string age = Console.ReadLine();

            Console.WriteLine();
            Console.Write($"Благодарим, {name} ({age}), за введенную информацию! Очень важный спам будет отправляться вам на почту!");
        }
    }
}
