using static System.Math;
namespace eph_tasks_81_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculations = new List<(Func<double, double>, double, double, double)>
        {
            (x => Log(x * x + 4, 3), -7.5, 8.3, 0.3), 
            (x => Pow((x + x * x), 7), -2.7, 3.3, 0.5),
            (x => Atan(x + 1), -4.8, 5.2, 0.2), 
            (x => Pow(E, x), -6.4, 2.4, 0.2),
            (x => 2 * x + Pow(x, 3), -3.3, 2.7, 0.3), 
            (x => x > 2 ? Pow(3, x + 4) : -8, -5, 8, 2), 
            (x => x > 7 ? Pow(E, Sin(x)) : 0, 10, 23, 3.2), 
            (x => x > 1 ? 6 * Pow(E, 8 * x) : x + 4, -3, 3, 0.8) 
        };

            foreach (var (func, start, end, step) in calculations)
            {
                Console.WriteLine("X\tY");
                for (double x = start; x <= end; x += step)
                {
                    Console.WriteLine($"{x}\t{func(x)}");
                }
                Console.WriteLine();
            }
        }
    }
}
