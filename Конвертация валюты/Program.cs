using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конвертация_валюты
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите рублевое значение");
            decimal decimalRuble = Convert.ToInt32(Console.ReadLine());
            decimal decimalDollar = decimalRuble * 76;
            Console.WriteLine($"{decimalRuble} руб. равно {decimalDollar}$");
            Console.ReadKey();

        }

    }
}
