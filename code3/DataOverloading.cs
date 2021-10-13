using System;
namespace code3
{
    public class Data
    {
        public string nama;
        public double nomorTelepon;

        public void print(string nama){
            this.nama = nama;
            Console.WriteLine($"Nama : {this.nama}");
        }

        public void print(double nomorTelepon){
            this.nomorTelepon = nomorTelepon;
            Console.WriteLine($"No Telp : {this.nomorTelepon}");
        }
    }
}