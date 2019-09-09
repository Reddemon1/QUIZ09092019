using System;

namespace QUIZ09092019
{
    class bangundatar
    {
               public void Luas_persegi()
        {
            int sisi , luas;

            Console.WriteLine("Menghitung luas persegi");
            Console.WriteLine("-----------------------");

            Console.Write("Sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;

            Console.WriteLine("Luas persegi = "+luas);
        }

        public void Luas_Segitiga()
        {
            int alas , tinggi , luas;

            Console.WriteLine("Menghitung Luas Segitiga");
            Console.WriteLine("------------------------");

            Console.Write("Alas = ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas * tinggi / 2;

            Console.WriteLine("Luas segitiga = "+luas);
        }
        public void luas_lingkaran()
        {
            double rusuk , luas;

            Console.WriteLine("Menghitung Luas Lingkaran");
            Console.WriteLine("-------------------------");

            Console.Write("Rusuk = ");
            rusuk = Convert.ToInt32(Console.ReadLine());

            luas = 3.14 * rusuk * rusuk;

            Console.WriteLine("Luas lingkaran = "+luas);
        }
    }
}