using System.Linq.Expressions;

namespace praktika_12
{
    internal class Program
    {
            static void TrianglePS(double a, out double P, out double S)
            {
                P = 3 * a;
                S = Math.Sqrt(Math.Pow(a, 2.0) * 3.0 / 4.0);
            }
        }

        static void Main(string[] args)
        {
            double P, S;
            Console.WriteLine("Введите длину стороны равностороннего треугольника: ");
            double a = double.Parse(Console.ReadLine());
            TrianglePS(a, out P, out S);
            Console.WriteLine("Периметр = " + P);
            Console.WriteLine("Площадь = " + S);
        }
    }
}
