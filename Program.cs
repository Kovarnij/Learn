﻿using System;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            Class7 class7 = new Class7();
            class7.Less10();
            string name;
            int age;
            int programCount;
            int money;
            int time;
            bool truth;

            name = "Best";
            age = 35;
            programCount = 2;
            money = 9999;
            time = 1;
            truth = true;

            Console.WriteLine("Здравствуйте, меня зовут " + name + ".");
            Console.WriteLine("Мне " + age + " лет.");
            Console.WriteLine("Я хочу научиться делать игры, это моя " + programCount + " программа на языке C#.");
            Console.WriteLine("Когда я закончу обучение я хочу зарабатывать " + money + " денег в " + time + " наносекунд.");
            Console.WriteLine("Достигну ли я желаемого? " + truth + "!");

            Console.ReadKey();
        }
    }
}