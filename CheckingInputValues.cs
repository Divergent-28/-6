using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    /// <summary>
    /// Класс содержащий методы для проверки вводимых данных.
    /// </summary>
    internal class CheckingInputValues
    {
        // <summary>
        /// Метод контроля ввода числа.
        /// </summary>
        public static bool ReadNumber(string text)
        {
            double n;
            while (!double.TryParse(text, out n))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод контроля ввода для числа а.
        /// </summary>
        public static bool ReadNumberA(string text)
        {
            double a1;
            if (!double.TryParse(text, out a1)|| a1 == 0)
            {
                return false;
            }
            return true;
            
        }
        /// <summary>
        /// Метод контроля ввода для числа b.
        /// </summary>
        public static bool ReadNumberB(string text)
        {
            double b1;
            if (!double.TryParse(text, out b1)||b1 <= 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод для контроля ввода выбора создания экземпляра класса.
        /// </summary>
        public static int Choice()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || (a != 1 && a != 2))
            {
                Console.WriteLine("Ошибка ввода");
            }
            return a;
        }
        /// <summary>
        /// Метод для контроля ввода длины массива.
        /// </summary>
        public static bool ArrayLen(string text)
        {
            int len;
            if (!int.TryParse(text, out len) || len <= 0 || len>50)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод для контроля ввода кол-ва попыток.
        /// </summary>
        public static bool ReadNumberP(string text)
        {
            int vbor;
            while (!int.TryParse(text, out vbor))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод для контроля ввода выбора символа для выхода из программы.
        /// </summary>
        public static char ReadChar()
        {
            char pod;
            while (!char.TryParse(Console.ReadLine(), out pod) || (pod != 'н' && pod != 'д'))
            {
                Console.WriteLine("Ошибка ввода");
            }
            return pod;
        }
    }
}
