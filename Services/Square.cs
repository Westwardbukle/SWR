using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Square
    {
        /// <summary>
        /// Вычесляет корни квадратного уравнения
        /// </summary>
        /// <param name="z">Первый коофицент</param>
        /// <param name="x">Второй коофицент</param>
        /// <param name="v">Третий коофицент</param>
        /// <returns>Результат вычесления</returns>
        public static string SquareMethod(double z, double x, double v)
        {
            double d = Math.Pow(x,2) - 4 * z * v;
            if (d > 0)
            {
                double x1 = (-x + Math.Sqrt(d)) / (2 * z);
                double x2 = (-x - Math.Sqrt(d)) / (2 * z);
                return $"Корень х1 ={x1}, х2={x2}";
            }
            else if (d == 0)
            {
                double x1 = -x / (2 * z);
                return $"Корень х1 ={x1}";
            }
            else
            {
                return "Корней нет";
            }
        }
    }
}
