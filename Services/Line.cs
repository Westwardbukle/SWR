using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Line
    {
        /// <summary>
        /// Вычесляет линейное уравнение
        /// </summary>
        /// <param name="k">Первый кооф</param>
        /// <param name="m">Второй кооф</param>
        /// <returns> Результат вычесления линейного уравнения </returns>
        public static string LineMethod(double k, double m)
        {
            if (k == 0 && m == 0)
            {
                return "Ответ R";
            }
            if (k == 0)
            {
                return "Нет решений";
            }

            double x = -m / k;

            return$"Ответ {x}";
        }
    }
}
