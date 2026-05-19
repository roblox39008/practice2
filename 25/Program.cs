namespace _25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырёхзначное число: ");
            int num = int.Parse(Console.ReadLine());

            int thousands = num / 1000;       
            int hundreds = (num / 100) % 10;     
            int tens = (num / 10) % 10;           
            int ones = num % 10;             

            int sum = thousands + hundreds + tens + ones;
            int product = thousands * hundreds * tens * ones;

            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");
        }
    }
}
