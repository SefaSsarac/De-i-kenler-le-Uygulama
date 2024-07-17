// See https://aka.ms/new-console-template for more information
using System;

namespace Degiskenler
{ 
    class Program
    { 
        static void Main(string[] args)
        { 
        
            Console.Write("T.C. Kimlik Numarasi:");

            string TCKimlikNo = Console.ReadLine();

            Console.Write("Adi:");

            string Ad = Console.ReadLine();

            Console.Write("Soyadi:");

            string Soyad = Console.ReadLine();

            Console.Write("Telefon Numarasi:");
            // Telefon Numarasini string olarak aldım, çünkü herhangi bir toplama çıkarma işlemi yapmayacağım.

            string TelefonNumarasi = Console.ReadLine();

            Console.Write("Yas:");

            string Yas = Console.ReadLine();

            Console.Write("Ilk Aldigi Urun Fiyati:");

            string fiyat1 = Console.ReadLine();

            int Ilkfiyat = Convert.ToInt32(fiyat1); // Burada metin değişkenini sayı değişkenine çeviriyorum

            Console.Write("Ikinci Aldigi Urun Fiyati:");

            string fiyat2 = Console.ReadLine();

            int Ikincifiyat = Convert.ToInt32(fiyat2); // Burada metin değişkenini sayı değişkenine çeviriyorum

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine($"{TCKimlikNo} TC Numarali {Ad} {Soyad} isimli kisi icin kayit olusturulmustur.");

            Console.WriteLine($"{TelefonNumarasi} numarasina bildirim mesaji gonderilmistir.");

            int toplam = Ilkfiyat + Ikincifiyat;

            int puan = toplam * 10 / 100; // Burada %10 u hesaplıyoruz.    

            Console.WriteLine($"{toplam} toplam harcama karsiligi kazanilan 10% patika puan mıktari: {puan}");

        }
    }
} 

