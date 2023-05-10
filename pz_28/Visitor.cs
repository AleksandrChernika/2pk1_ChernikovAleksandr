namespace pz_28
{
    class Visitor
    {
        static int count;
        public Visitor()
        {
            count++;
            Console.WriteLine($"Посетитель {count} пришел.");
        }
    }
}
