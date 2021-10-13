using System;

namespace code3
{
    public class Pesawat
    {
        public string nama;
        protected int _ketinggian;
        public int jumlahRoda;
        public int jumlahPenumpang;

        public int ketinggian{
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

    public class PesawatTempur: Pesawat
    {
        
        public void terbangTinggi(){
            Console.WriteLine($"Pesawat tempur {this.nama} punya roda {this.jumlahRoda}, sedang berada di ketinggian {this._ketinggian} dengan jumlah penumpang {this.jumlahPenumpang} orang akan meledakkan senjata");
        }
    }
}