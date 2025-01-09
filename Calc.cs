using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    internal class Calc
    {
        /// <summary>
        /// Метод, вычисляющий формулу.
        /// </summary>
        public static double Calculating(double a, double b)
        {
            a = a * (Math.PI / 180);
            double Ln = Math.Log(b);
            double result = Math.Pow(Ln, 2) / (Math.Cos(a) - 1);
            result = Math.Round(result, 2);
            return result;
        }
    }
}
