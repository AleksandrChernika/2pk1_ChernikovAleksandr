namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int x = 1;
            Console.WriteLine("Число " + "квадрат " + "куб");
            while (0 < x && x < 11)
            {
                Console.WriteLine(x + " " + Math.Pow(x, 2) + " " + Math.Pow(x, 3));
                x++;
            }
            
            int y = 0;
            Console.WriteLine("Число " + "квадрат " + "куб");
            do
            {
                y++;
                Console.WriteLine(y + " " + Math.Pow(y, 2) + " " + Math.Pow(y, 3));

            }
            while (y > 0 && y < 10);
               

        }
    }
}