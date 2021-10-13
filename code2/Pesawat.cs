using System;

namespace code2
{
    public class Pesawat
    {
        public string nama;
        private double _ketinggian;

        public double ketinggian{
            get {return this._ketinggian;}
            set {this._ketinggian = value;}
        }

        public void terbang(){
            Console.WriteLine($"Pesawat {this.nama} sedang take off");
        }

        public void sudahTerbang(){
            Console.WriteLine($"Pesawat {this.nama} sudah terbang dengan ketinggian {this._ketinggian}");
        }
    }
}