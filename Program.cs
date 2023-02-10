using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20_СамРабота_Делегаты_События_Лямбды
{
    class Program
    {
        delegate double CircleCalculationsDelegate(double radius);        

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус/radius:");
            double r = Convert.ToDouble(Console.ReadLine());

            CircleCalculationsDelegate del = Length;
            Console.WriteLine("Длина окружности: {0:f2}", del(r));

            del = Square;
            Console.WriteLine("Площадь круга: {0:f2}", del(r));

            del = Volume;
            Console.WriteLine("Объем шара: {0:f2}", del(r));

            Console.ReadKey();
        }

        static double Length(double r) => Math.PI * 2 * r;
        static double Square(double r) => Math.PI * r * r;
        static double Volume(double r) => (Math.PI * r * r * 3 * 4) / 3;

    }    
}
