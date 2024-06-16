//CLASS MOBIL
PBO.car mobil1 = new PBO.car(); // car digunakan sebagai class yang mana variabel
mobil1 dimasukkan kedalam class car
mobil1.merk = "Toyota";//properti mobil1
mobil1.jenis = "Supra ";
mobil1.hp = "280 hp";
PBO.car mobil2 = new PBO.car();// car digunakan sebagai class yang mana variabel
//mobil2 dimasukkan kedalam class car
mobil2.merk = "Nissan";//properti mobil2
mobil2.jenis = "GTR R35 ";
mobil2.hp = "570 hp";
PBO.car mobil3 = new PBO.car();// car digunakan sebagai class yang mana variabel
//mobil3 dimasukkan kedalam class car
mobil3.merk = "Audi";//properti mobil3
mobil3.jenis = "R8 ";
mobil3.hp = "562 hp";
mobil1.print();//memunculkan output dari variabel mobil 1,2,dan 3
mobil2.print();
mobil3.print();
namespace PBO//deklarasi ruang lingkup objek
{
    class car//pemanggilan data car
    {
        public string? merk;//pemanggilan properti menggunakan tipe data
        public string? jenis;
        public string? hp;

        public void print()//digunakan agar metode tidak mengembalikan nilai
        {
            Console.WriteLine("Merk : " + this.merk);//menampilkan properti menjadi
            beberapa baris
        Console.WriteLine("Jenis : " + this.jenis);
            Console.WriteLine("HP : " + this.hp);
            Console.WriteLine("\n");//spacing pada hasil running
        }
    }
}