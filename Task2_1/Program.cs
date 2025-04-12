namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d;
            d = c;
            c = b;
            b = a;
            a = d;
            Console.WriteLine("{0} {1} {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
