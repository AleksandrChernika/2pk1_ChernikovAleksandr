namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mass1 = new int[10];
            int[] mass2 = new int[10];
            int[] mass3 = new int[10];
            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = rnd.Next(1,100);
                Console.WriteLine("Введите " + (i+1) + " элемент массива");
                mass2[i] = Convert.ToInt32(Console.ReadLine());
                mass3[i] = mass1[i] + mass2[i];
            }
            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write(mass1[i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write(mass2[i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write(mass3[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}