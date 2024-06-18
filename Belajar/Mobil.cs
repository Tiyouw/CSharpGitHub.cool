using System;

namespace Materi
{
    public class Mobil
    {
        public string merk;
        public string warna;
        public int jumlahBan;

        public void Maju()
        {
            Console.WriteLine("Mobil " + this.merk + " Jalan Maju");
        }
    }
}