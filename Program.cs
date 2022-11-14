namespace pz_13
{
    internal class Program
    {
        static IEnumerable<string> Method(string[] mas)
        {
            for (int i = 0; i < mas[4].Length; i++)
            {
                mas[i] = mas[i].PadRight(mas[4].Length, '*');
                Console.WriteLine(mas[i]);
            }
            return mas;
        }

            static void Main(string[] args)
        {
            string[] mas = new string[] { "a", "bb", "ccc", "dddd", "eeeee" };
            Method(mas);
        }
    }
}