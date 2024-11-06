using System;
namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.TimeOfDay);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//10
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday
            Console.WriteLine(DateTime.Now.ToString("MM"));//07
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Jul
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//July
            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021
            Console.WriteLine(DateTime.Now.ToString("hh"));//05
            Console.WriteLine(DateTime.Now.ToString("HH"));//17
            Console.WriteLine(DateTime.Now.ToString("mm"));//45
            Console.WriteLine(DateTime.Now.ToString("ss"));//30
            Console.WriteLine(DateTime.Now.ToString("tt"));//   PM
            Console.WriteLine(DateTime.Now.ToString("d"));//7/10/2021
            Console.WriteLine(DateTime.Now.ToString("D"));//Saturday, July 10, 2021
            Console.WriteLine(DateTime.Now.ToString("t"));//5:45 PM
            Console.WriteLine(DateTime.Now.ToString("T"));
            Console.WriteLine(DateTime.Now.ToString("f"));
            Console.WriteLine(DateTime.Now.ToString("F"));
            Console.WriteLine(DateTime.Now.ToString("g"));
            Console.WriteLine(DateTime.Now.ToString("G"));
            Console.WriteLine(DateTime.Now.ToString("M"));
            Console.WriteLine(DateTime.Now.ToString("R"));
            Console.WriteLine(DateTime.Now.ToString("s"));
            Console.WriteLine(DateTime.Now.ToString("u"));
            Console.WriteLine(DateTime.Now.ToString("U"));
            Console.WriteLine(DateTime.Now.ToString("Y"));

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//mutlak değer
            Console.WriteLine(Math.Sin(10));//
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            Console.WriteLine(Math.Ceiling(22.3));//yukarı yuvarlar    
            Console.WriteLine(Math.Floor(22.7));//aşağı yuvarlar
            Console.WriteLine(Math.Round(22.3));//en yakın sayıya yuvarlar
            Console.WriteLine(Math.Round(22.7));//en yakın sayıya yuvarlar
            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));
            Console.WriteLine(Math.Pow(3, 4));//3^4
            Console.WriteLine(Math.Sqrt(9));//karekök
            Console.WriteLine(Math.Log(9));//e tabanında logaritma
            Console.WriteLine(Math.Exp(3));//e üzeri 3
            Console.WriteLine(Math.Log10(10));//10 tabanında logaritma
        }
    }
}