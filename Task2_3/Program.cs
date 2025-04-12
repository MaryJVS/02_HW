namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину отрезка в дюймах");
            double d = Convert.ToDouble(Console.ReadLine());
            const double k = 2.54;
            double m = d * k; // Перевод в метрическую систему (в см)
            int a = Convert.ToInt32(m) / 100; // Перевод см в м
            int b = Convert.ToInt32(m % 100); // Вычленение см
            double c = m * 10 % 10; // Вычленение мм
            double rounded = Math.Round(c, 2);

            Console.WriteLine("Длина отрезка составляет {0} м {1} см {2} мм", a, b, rounded);
            Console.ReadLine();
        }
    }
}
