namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // создаём генератор случайных чисел
            Console.WriteLine(rnd.Next());        // случайное число от 0 до int.MaxValue
            Console.WriteLine(rnd.Next(5));       // случайное число от 0 до 4
            Console.WriteLine(rnd.Next(-5, 5));   // случайное число от -5 до 4

        }
    }
}
