namespace _24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = double.Parse(Console.ReadLine());
            double a2 = a * a;
            double a4 = a2 * a2;
            Console.WriteLine($"a^4 = {a4}");

            double a3 = a * a * a;
            double a6 = a3 * a3;   

            double a2b = a * a;     
            double a4b = a2b * a2b; 
            double a6b = a4b * a2b; 
            Console.WriteLine($"a^6 = {a6b}");

            double a2v = a * a;      
            double a4v = a2v * a2v;
            double a6v = a4v * a2v;   
            double a7v = a6v * a;    
            Console.WriteLine($"a^7 = {a7v}");

            double a2g = a * a;      
            double a4g = a2g * a2g;  
            double a8g = a4g * a4g;   
            Console.WriteLine($"a^8 = {a8g}");

            double a2d = a * a;     
            double a4d = a2d * a2d; 
            double a8d = a4d * a4d;  
            double a9d = a8d * a;   
            Console.WriteLine($"a^9 = {a9d}");

            double a2e = a * a;     
            double a4e = a2e * a2e; 
            double a8e = a4e * a4e; 
            double a10e = a8e * a2e;
            Console.WriteLine($"a^10 = {a10e}");
        }
    }
}
