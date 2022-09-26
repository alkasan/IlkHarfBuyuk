using System;

namespace IlkHarfBuyuk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle Giriniz: ");
            string cumle = Console.ReadLine();
            string[] dizi = cumle.Split(' ');
            for (int i = 0; i < dizi.Length; i++)
            dizi[i] = dizi[i][0].ToString().ToUpper() + dizi[i].Substring(1);
            string ilkHarfBuyuk = string.Join(" ", dizi);
            Console.WriteLine(ilkHarfBuyuk);
        }
    }
}

