﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çoklu_sayı_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, c, d = 0, f, e;
            Console.WriteLine("Kaç Adet Sayi Girmek İstediğinizi Yazin");
            a = Convert.ToInt32(Console.ReadLine());
            f = a;
            do
            {
                Console.WriteLine("Bir Sayi giriniz" + "(" + a + ")");
                c = Convert.ToInt32(Console.ReadLine());
                a--;
                d += c;
            } while (a > 0);
            e = d / f;
            Console.WriteLine("Girdiğiniz Sayıların Toplamı: " + d);
            Console.WriteLine("Girdiğiniz Sayıların Ortalaması: " + e);
        }
    }
}
