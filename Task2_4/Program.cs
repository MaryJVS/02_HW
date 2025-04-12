namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            int m = Convert.ToInt32(Console.ReadLine());
            int a = m / 1000;
            int b = m / 100 % 10;
            int c = m / 10 % 10;
            int d = m % 10;
            int s = a * 1000 + d * 100 + c * 10 + b;
            Console.WriteLine("Результат {0}", s);
            Console.ReadKey();
        }
    }
}
