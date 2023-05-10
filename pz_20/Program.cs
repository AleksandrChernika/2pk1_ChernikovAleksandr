namespace pz_20
{
    internal class Program
    {
        static string SimZam(ref string a)
        {
            try
            {
                char[] ch = a.ToCharArray();

                for (int i = 0; i < ch.Length; i++)
                {
                    if (char.IsUpper(ch[i]))
                    {
                        ch[i] = char.ToLower(ch[i]);
                    }
                    else if (char.IsLower(ch[i]))
                    {
                        ch[i] = char.ToUpper(ch[i]);
                    }
                }
                a = new string(ch);
                Console.WriteLine(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string a = Console.ReadLine();
            SimZam(ref a);
        }
    }
}