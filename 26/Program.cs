namespace _26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 2, c = 2;
            double z;

            c = 2; z = (a * b + c++) / (b - a * b * --c);
            Console.WriteLine("3.66: " + z);

            c = 2; z = a * b + (c++ / b - a) * b * --c;
            Console.WriteLine("-1: " + z);

            c = 2; z = (a * b + c++) / b - a * b * --c;
            Console.WriteLine("2: " + z);

            c = 2; z = a * (b + c++) / b - a * b * --c;
            Console.WriteLine("-2: " + z);

            c = 2; z = a * b + c++ / (b - a) * b * --c;
            Console.WriteLine("-4: " + z);
        }
    }
}
