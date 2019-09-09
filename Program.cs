using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            bangundatar panggil = new bangundatar();

            panggil.Luas_persegi();
            panggil.Luas_Segitiga();
            panggil.luas_lingkaran();

            bangunruang kela = new bangunruang();

            kela.volume_balok();
            kela.volume_kubus();
        }
    }
}
