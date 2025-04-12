namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы в метрах");
            double length = Convert.ToDouble(Console.ReadLine());
            double lengthRounded = Math.Ceiling(length);
            Console.WriteLine("Округленное значение длины трубы = {0}", lengthRounded);
            Console.ReadKey();
        }
    }
}
