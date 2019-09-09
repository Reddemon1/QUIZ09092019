using System;

namespace QUIZ09092019
{
    class bangunruang
    {
        public void volume_balok()
      {
         int panjang , lebar , tinggi , volume ;

         Console.WriteLine("Menghitung Volume Balok");
         Console.WriteLine("-----------------------");

         Console.Write("Panjang = ");
         panjang = Convert.ToInt32(Console.ReadLine());

         
         Console.Write("Lebar = ");
         lebar = Convert.ToInt32(Console.ReadLine());

        
         Console.Write("Tinggi = ");
         tinggi = Convert.ToInt32(Console.ReadLine());


         volume = panjang * lebar * tinggi ;

         Console.WriteLine("Volume balok adalah = "+volume);
      }
        public void volume_kubus()
        {
         int rusuk , volume ;

         Console.WriteLine("Menghitung Volume Kubus");
         Console.WriteLine("-----------------------");

         Console.Write("Rusuk = ");
         rusuk = Convert.ToInt32(Console.ReadLine());

         volume = rusuk * rusuk * rusuk ;

         Console.WriteLine("Volume kubus = "+volume);
        }

    }
}