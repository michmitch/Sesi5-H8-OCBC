using System;

namespace code1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop asus = new Laptop();
            Console.Write("Merk Laptop : ");
            string merk = Console.ReadLine();
            asus.merk = merk;

            Console.Write("RAM Laptop : ");
            int ram = int.Parse(Console.ReadLine());
            asus.ram = ram;

            Console.Write("Memory Laptop : ");
            int memory = int.Parse(Console.ReadLine());
            asus.memory = memory;

            Console.WriteLine("==============================");

            Console.WriteLine($"Merk laptop : {asus.merk}");
            Console.WriteLine($"RAM laptop : {asus.ram}");
            Console.WriteLine($"Memory laptop : {asus.memory}");

            asus.Chatting();
            asus.Sosmed();
            asus.OlShop();
        }
    }
}
