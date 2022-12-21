namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "текст текст /* комментарий */ текст //комент \nтекст";
            string str2 = string.Empty;
            string str3 = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                int a = str.IndexOf("/*");
                int b =  str.IndexOf("*/");
                str2 = str.Remove(a, b - a + 3);
            }
            for (int i = 0; i < str2.Length; i++)
            {
                int a = str2.IndexOf("//");
                int b = str2.IndexOf("\n");
                str3 = str2.Remove(a, b - a );
            }
            Console.WriteLine(str3);
        }
    }
}