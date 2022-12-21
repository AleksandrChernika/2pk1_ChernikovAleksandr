namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string log = Console.ReadLine();
            Console.WriteLine("Введите пароль(он должен быть не менее 8 символов, а так же содержать символы $ _ !): ");
            string pass = Console.ReadLine();
            if (pass.Length>=8)
            {
                if (pass.Contains("$")&& pass.Contains("_")&& pass.Contains("!"))
                { 
                    Console.WriteLine("пароль коректный");
                }
            }
            else Console.WriteLine("пароль не верен");
        }
    }
}