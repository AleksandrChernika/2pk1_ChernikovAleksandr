using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    class Controller
    {
        const int maxVisitors = 30;
        int currentVisitors;

        public void AddVisitor(Visitor visitor)
        {
            if (currentVisitors < maxVisitors)
            {
                currentVisitors++;
                Console.WriteLine($"Текущее количество посетителей: {currentVisitors}");
            }
            else
            {
                Console.WriteLine("Максимум посетителей.");
            }
        }
    }
}
