using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            faktorial clc = new faktorial();
            Console.WriteLine("bir eded daxil edin...");
            clc.n = Convert.ToInt32(Console.ReadLine());
            clc.result = 1;
            clc.FaktorialCalculation();

        }
    }
}
