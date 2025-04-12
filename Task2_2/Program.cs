namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение угла в градусах, минутах и секундах");
            int grad = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int sec = Convert.ToInt32(Console.ReadLine());
            double angleToGrad = grad % 360 + min / 60.0 + sec / 3600.0;
            double gradToRad = angleToGrad * Math.PI / 180;
            Console.WriteLine("Значение угла в радианах равно {0}", gradToRad);
            Console.ReadKey();
        }
    }
}
