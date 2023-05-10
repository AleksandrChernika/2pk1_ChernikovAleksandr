using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 2
            Console.WriteLine("Задание 2:");
            Console.WriteLine();
            Temperature temperature = new Temperature();

            temperature.TemperatureChanged += (sender, e) =>
            {
                if (e.Temperature == -25)
                {
                    Console.WriteLine("Темпертура: -25");
                }
                else if (e.Temperature == 0)
                {
                    Console.WriteLine("Темпертура: 0");
                }
                else if (e.Temperature == 25)
                {
                    Console.WriteLine("Темпертура: 25");
                }
                else if (e.Temperature == 35)
                {
                    Console.WriteLine("Темпертура: 35");
                }
            };
            temperature.Start();

            Console.WriteLine();

            // Вариант 5
            Visitor[] visitors = new Visitor[35];
            Controller controller = new Controller();

            for (int i = 0; i < visitors.Length; i++)
            {
                visitors[i] = new Visitor();
                controller.AddVisitor(visitors[i]);
            }
            Console.ReadKey();
        }
    }
}