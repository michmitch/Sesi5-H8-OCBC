using System;

namespace code3
{
    class Program
    {

        public static void nomor1(){
            Pesawat pesawat = new Pesawat();
            PesawatTempur pesawattempur = new PesawatTempur();

            Console.Write("Nama Pesawat : ");
            pesawat.nama = Console.ReadLine();

            Console.Write("Ketinggian Pesawat : ");
            pesawat.ketinggian = int.Parse(Console.ReadLine());

            Console.Write("Roda Pesawat : ");
            pesawat.jumlahRoda = int.Parse(Console.ReadLine());

            Console.Write("Penumpang Pesawat : ");
            pesawat.jumlahPenumpang = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Nama Pesawat Tempur : ");
            pesawattempur.nama = Console.ReadLine();

            Console.Write("Ketinggian Pesawat Tempur : ");
            pesawattempur.ketinggian = int.Parse(Console.ReadLine());

            Console.Write("Roda Pesawat Tempur : ");
            pesawattempur.jumlahRoda = int.Parse(Console.ReadLine());

            Console.Write("Penumpang Pesawat Tempur : ");
            pesawattempur.jumlahPenumpang = int.Parse(Console.ReadLine());

            pesawat.terbang();
            pesawattempur.terbangTinggi();
        }

        public static void nomor2(){

            Console.Write("Nama : ");
            string nama = Console.ReadLine();

            Console.Write("No Telp : ");
            double notelp = double.Parse(Console.ReadLine());
            Data data = new Data();
            
            data.print(nama);
            data.print(notelp);
        }

        public static void nomor3(){
            Bilangan bilangan = new Bilangan();
            bilangan.setBilangan(10,5);
            bilangan.tambahKali();

            bilangan = new BilanganOverride();
            bilangan.setBilangan(20, 5);
            bilangan.tambahKali();
        }

        static void Main(string[] args)
        {
            int menuchoice;
            string submenuchoice = "y";
            do
            {
                Console.WriteLine("1. Pesawat tempur");
                Console.WriteLine("2. Overloading");
                Console.WriteLine("3. Bilangan");
                Console.WriteLine("4. Tentang Saya");
                Console.Write("Pilihan : ");
                menuchoice = int.Parse(Console.ReadLine());

                if(menuchoice == 1){
                    nomor1();
                }

                else if(menuchoice == 2){
                    nomor2();
                }

                else if(menuchoice == 3){
                    nomor3();
                }

                else if(menuchoice == 4){
                    Console.WriteLine("Nama : Michael Christiawan");
                    Console.WriteLine("Asal : Semarang");
                    Console.WriteLine("Sejauh ini cukup menarik karena belajar bahasa baru");
                }

                Console.Write("Kembali Ke Menu Utama? (y/n) : ");
                submenuchoice = Console.ReadLine();
                Console.Clear();
                
            } while (submenuchoice == "y");
        }
    }
}
