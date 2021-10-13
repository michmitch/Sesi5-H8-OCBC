using System;

namespace code2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();

            Console.Write("Nama Pesawat : ");
            pesawat.nama = Console.ReadLine();

            Console.Write("Ketinggian : ");
            pesawat.ketinggian = double.Parse(Console.ReadLine());

            pesawat.terbang();
            pesawat.sudahTerbang();
        }
    }
}
