using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20
{
    /* В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре следующие:
     * - метод получает входным параметром переменную типа double;
     * - метод возвращает значение типа double, которое является результатом вычисления.
     * Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
     * - длину окружности по формуле D = 2 *Pi *R;
     * - площадь круга по формуле S = Pi*R^2
     * - объем шара по формуле V = 4/3 * Pi * R^3.
     * Методы должны быть объявлены как статические.*/
    class Program
    {
        delegate double Calculation(double r);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Calculation length = GetLength;
            Calculation square = GetSquare;
            Calculation volume = GetVolume;
            double l = Math.Round(length(r), 2);
            double s = Math.Round(square(r), 2);
            double v = Math.Round(volume(r), 2);
            Console.WriteLine("Длина окружности = {0}\nПлощадь круга = {1}\nОбъем шара = {2}", l, s, v);
            Console.ReadKey();
        }
        static double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static double GetSquare(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        static double GetVolume(double r)
        {
            return 4 * Math.PI * Math.Pow(r, 3) / 3;
        }
    }
}
