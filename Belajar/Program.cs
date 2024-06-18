using System;
using Materi;

public class Program
{
	static void Main(string[]args)
	{
		Mobil mobil1 = new Mobil();
		mobil1.merk = "Toyota";
		mobil1.warna = "black";
		mobil1.jumlahBan = 4;
		mobil1.Maju();

		Mobil mobil2 = new Mobil();
		mobil2.merk = "Suzuki";
		mobil2.warna = "white";

		Console.ReadLine();
	}
}
