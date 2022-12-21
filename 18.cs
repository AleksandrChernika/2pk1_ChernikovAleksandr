namespace pz_18
{

    internal class Program
    {
        public enum Marks: int //создание перечисления
        {
            Very_bad = 1,
            Bad = 2,
            Normal = 3,
            Good = 4,
            Very_good = 5
        }
        static void Main(string[] args)
        {
            try //для обработки исключений
            {
                int str = int.Parse(Console.ReadLine());
                switch (str) //метод switch
                {
                    case (int)Marks.Very_bad:
                        {
                            Console.WriteLine("Очень плохо");
                            break;
                        }
                    case (int)Marks.Bad:
                        {
                            Console.WriteLine("Плохо");
                            break;
                        }
                    case (int)Marks.Normal:
                        {
                            Console.WriteLine("Удовлетворительно");
                            break;
                        }
                    case (int)Marks.Good:
                        {
                            Console.WriteLine("Хорошо");
                            break;
                        }
                    case (int)Marks.Very_good:
                        {
                            Console.WriteLine("Очень хорошо");
                            break;
                        }
                    default:
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}   

