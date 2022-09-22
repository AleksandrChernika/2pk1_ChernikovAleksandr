namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = -100; i <= 0; i += 2)
            {
                Console.WriteLine(i);
            }

            for (char i = 'к'; i <= 'т'; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            int n = 4;
            int m = 8;
            for (int i = 0; i < m; i++)
            {
                for (int z = 0; z < n; z++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            int x = 0;
            for (int i = 0; i < 100; i++)          
            {
                if (x == i % 17)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 0, j = 55;j-i != 9;i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }


        }
    }
}
