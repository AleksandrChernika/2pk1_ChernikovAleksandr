namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] A = new double[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rnd.Next(1,100) + Math.Round(rnd.NextDouble(),2);
                    Console.Write(A[i,j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            double[] mass1 = new double[n];
            double[] mass2 = new double[n];

            for (int i = 0; i < n; i++)
            {
                mass1[i] = A[i, i];
                mass2[i] = A[i, n-1-i];
            }
            for (int i = 0; i < n; i++)
            {
                A[n - 1 - i, n - 1 - i] = mass1[i];
                A[n - 1 - i, i] = mass2[i];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}