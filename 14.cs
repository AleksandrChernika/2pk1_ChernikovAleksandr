namespace pz_14
{
    internal class Program
    {
        static double Arif(double a, double b, double c)
        {
            if (c == 0)
            {
                return a;
            }
            else
            {
                Console.Write(Math.Round(a, 1) + "   ");
                a = a + b;
                c = c - 1;
                Arif(a, b, c);
                return a;
            }
        }
        static double Geom(double a, double b, double c)
        {
            if (c == 0)
            {
                return a;
            }
            else
            {
                Console.Write(Math.Round(a, 1) + "   ");
                a = a * b;
                c = c - 1;
                Geom(a, b, c);
                return a;
            }
        }
        static void Chisla(int a, int b)
        {
            if (a < b)
            {
                a++;
                Console.Write(a + "   ");
                Chisla(a, b);
            }
            if (a > b)
            {
                a--;
                Console.Write(a + "   ");
                Chisla(a, b);
            }
            else
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия: ");
            Console.WriteLine();
            double x = 1;
            double y = 2;
            Console.WriteLine("Введите количество членов арифметической прогрессии: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Arif(x, y, z);
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Геометрическая прогрессия: ");
            Console.WriteLine();
            double q = 6;
            double w = -5;
            Console.WriteLine("Введите количество членов геометрическая прогрессии: ");
            double e = Convert.ToDouble(Console.ReadLine());
            Geom(q, w, e);
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Числа в промежутке: ");
            Console.WriteLine();
            int m = 64;
            int n = 54;
            Chisla(m, n);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}