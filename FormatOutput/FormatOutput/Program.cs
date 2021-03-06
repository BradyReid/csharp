﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FormatOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Green;
            Beep();
            double miles = 4.5;
            double feet;
            double inches;
            feet = 5280 * miles;
            inches = 12 * feet;
            WriteLine("Miles: {0:N2}", miles);
            WriteLine("Feet: {0}", feet);
            WriteLine("Inches: {0}", inches);
            WriteLine("");
            miles = 3.5;
            double km;
            km = miles * 1.60934;
            WriteLine("Miles: {0:N2}", miles);
            WriteLine("Kilometers: {0:N2}", km);
            WriteLine("");
            double c = 0;
            double f;
            f = (c * (9 / 5)) + 32;
            WriteLine("Celsius: {0:N2}", c);
            WriteLine("Fahrenheit: {0:N2}", f);
            WriteLine("");
            double r = 52;
            double m;
            m = 52 * 1.15;
            WriteLine("Price: {0:C2}", r);
            WriteLine("Price after Markup: {0:C2}", m);
            ReadLine();
        }
    }
}
