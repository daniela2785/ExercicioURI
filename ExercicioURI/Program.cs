using System;
using System.Globalization;
using System.Net.Http.Headers;

class URI
{
    static void Main(string[] args)
    {
        /*exercicio 1004
            int a, b, PROD;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine("PROD = " + PROD);
        }*/


        /* EXERCICIO 1006
        double A, B, media;

        A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = ((A * 3.5) + (B * 7.5)) / 11;

        Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        */



        //EXERCICIO 1006
        double A, B, C, media;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (A * 2.0 + B * 3.0 + C * 5) / 10.0;

        Console.WriteLine("MÉDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
    }
}