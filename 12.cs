namespace pz_12
{
    internal class Program
    {
        static double a;
        static double P;
        static double S;

        static void TrianglePS()
        {
            P = a * 3;
            S = Math.Pow(a, 2) * Math.Sqrt(3.0 / 4.0);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите длину стороны равностороннего треугольника: ");
            a = Convert.ToDouble(Console.ReadLine());
            TrianglePS();
            Console.WriteLine("Периметр треугольника равен: " + P);
            Console.WriteLine("Площадь треугольника равна: " + S);
        }
    }
}