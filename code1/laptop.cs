using System;

namespace code1
{
    public class Laptop
    {
        public string merk;
        public int ram;
        public int memory;        

        public void Chatting(){
            Console.WriteLine($"{this.merk} sedang chatting");
        }

        public void Sosmed(){
            Console.WriteLine($"{this.merk} sedang chatting");
        }

        public void OlShop(){
            Console.WriteLine($"{this.merk} sedang belanja online shop");
        }
    }
}