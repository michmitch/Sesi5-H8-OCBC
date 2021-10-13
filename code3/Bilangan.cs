using System;

namespace code3
{
    public class Bilangan
    {
        public int bil1, bil2;

        public void setBilangan(int bil1, int bil2){
            this.bil1 = bil1;
            this.bil2 = bil2;
        }

        public virtual void tambahKali(){
            Console.WriteLine("Overriding 1");
            Console.WriteLine($"Hasil Penjumlahan Angka {this.bil1} dan {this.bil2} = {this.bil1 + this.bil2}");
            Console.WriteLine($"Hasil Perkalian Angka {this.bil1} dan {this.bil2} = {this.bil1 * this.bil2}");
        }
    }

    public class BilanganOverride: Bilangan
    {
        public override void tambahKali(){
            Console.WriteLine($"Hasil Pembagian Angka {this.bil1} dan {this.bil2} = {this.bil1 / this.bil2}");
            Console.WriteLine($"Hasil Pengurangan Angka {this.bil1} dan {this.bil2} = {this.bil1 - this.bil2}");
        }
    }
}