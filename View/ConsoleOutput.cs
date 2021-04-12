using System;
using Envelopee.BL;

namespace Envelopee.View
{
    class ConsoleOutput
    {
        Envelope a;
        Envelope b;

        public ConsoleOutput()
        {
            Continue();
        }

        public Envelope Input()
        {
            Console.WriteLine("Введите длину конверта");
            string parameters = Console.ReadLine();
            if(!float.TryParse(parameters, out float l))
            {
                throw new ArgumentException("Ширина не являются числом");
            }
            Console.WriteLine("Введите ширину конверта");
            parameters = Console.ReadLine();
            if (!float.TryParse(parameters, out float w))
            {
                throw new ArgumentException("Длина не являются числом");
            }
            return new Envelope(l, w);
        }

        public void View()
        {
            if(a.CheckEnvelops(b) ==1)
            {
                Console.WriteLine("Первый конверт влезает во второй");
            }
            else if (a.CheckEnvelops(b) == 2)
            {
                Console.WriteLine("Второй конверт влезает в первый");
            }
            else
                Console.WriteLine("Конверты не влезают друг в друга");
            Console.ReadLine();
            
        }

        public void Continue()
        {
            a = Input();
            b = Input();
            View();
            Console.WriteLine("Продолжить?");
            string check = Console.ReadLine();
            if (check.ToLower() == "y" || check.ToLower() == "yes")
            {
                Continue();
            }
            else return;
        }
    }
}
