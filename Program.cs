using System.Linq.Expressions;

namespace praktika_12
{
    internal class Program
    {
        static IEnumerable<string> Method(string [] mas)
        {
            for (int i = 0; i < mas[4].Length; i++)
            {
                mas[i] = mas[i].PadRight(mas[4].Length, '*');
                Console.WriteLine(mas[i]);
            }
            return mas;
            /*
            static void TrianglePS(double a, out double P, out double S)
            {
                P = 3 * a;
                S = Math.Sqrt(Math.Pow(a, 2.0) * 3.0 / 4.0);
            }
            */
        }

        static void Main(string[] args)
        {
            string [] mas = new string[] { "a", "bb", "ccc", "dddd", "eeeee" }; 
            Method (mas);
           /*
            double P, S;
            Console.WriteLine("Введите длину стороны равностороннего треугольника: ");
            double a = double.Parse(Console.ReadLine());
            TrianglePS(a, out P, out S);
            Console.WriteLine("Периметр = " + P);
            Console.WriteLine("Площадь = " + S);
           */
        }
    }
}