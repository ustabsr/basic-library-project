using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kitaplikProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            string secim;
            Console.WriteLine("Türkçe Kitap Kategorisi   *******************  Yabancı Kitap Kategorisi");
            Console.WriteLine();
            Console.WriteLine("1.Masumiyet Müzesi: Orhan Pamuk                7.Martin Eden: Jack London");
            Console.WriteLine();
            Console.WriteLine("2.Beyaz Leke: Aslı Arslan                      8.Yaşamak: Yu Hua");
            Console.WriteLine();
            Console.WriteLine("3.Yağmur Çiseliyor: Osman Balcıgil             9.Körlük: Jose Saramago");
            Console.WriteLine();
            Console.WriteLine("4.Sazın Teli Koptu: Zülfü Livaneli             10.Yabancı: Albert Camus");
            Console.WriteLine();
            Console.WriteLine("5.Beser Hatun: Ali Kılıç                       11.1984: George Orwell");
            Console.WriteLine();
            Console.WriteLine("6.Yaralasar: Maral Atmaca                      12.Bülbülü Öldürmek: Harper Lee");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------- İşlemler Menüsü --------");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Kitap Arşivi");
            Console.WriteLine("4-Yeni Kitap Satın Al");
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemin numarasını giriniz: ");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            
            if (islem=='1')
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitap numarasını giriniz: ");
                string numara;
                numara= Console.ReadLine();
                switch (numara) 
                {
                    case "1": Console.Write("1.Masumiyet Müzesi: 196 TL"); break;
                    case "2": Console.Write("2.Beyaz Leke: 227 TL"); break;
                    case "3": Console.Write("3.Yağmur Çiseliyor: 227 TL"); break;
                    case "4": Console.Write("4.Sazın Teli Koptu: 132 TL"); break;
                    case "5": Console.Write("5.Beser Hatun: 101 TL"); break;
                    case "6": Console.Write("6.Yaralasar: 219 TL"); break;
                    case "7": Console.Write("7.Martin Eden: 64 TL"); break;
                    case "8": Console.Write("8.Yaşamak: 92 TL"); break;
                    case "9": Console.Write("9.Körlük: 179 TL"); break;
                    case "10": Console.Write("10.Yabancı: 74 TL"); break;
                    case "11": Console.Write("11.1984: 64 TL"); break;
                    case "12": Console.Write("12.Bülbülü Öldürmek: 157 TL"); break;
                    default: Console.Write("Böyle bir kitap mevcut değildir, numarayı tekrar giriniz."); break;

                }

            }
            if (islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversite: ");
                universite = Console.ReadLine();

                string dosya = @"C:\Users\ustab\OneDrive\Masaüstü\kullanici.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversite: " + universite);
                sw.Close();
            }
            if (islem == '3')
            {
                Console.WriteLine("********************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\ustab\OneDrive\Masaüstü\Kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("********************");
            }
            if (islem == '4')
            {
                for(int i=1; i<=100;  i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Alacağınız kitap numarası: ");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        toplam = toplam + 196;
                    }
                    else if(secim == "2")
                    {
                        toplam = toplam + 227;
                    }
                    else if (secim == "3")
                    {
                        toplam = toplam + 227;
                    }
                    else if (secim == "4")
                    {
                        toplam = toplam + 132;
                    }
                    else if (secim == "5")
                    {
                        toplam = toplam + 101;
                    }
                    else if (secim == "6")
                    {
                        toplam = toplam + 219;
                    }
                    else if (secim == "7")
                    {
                        toplam = toplam + 64;
                    }
                    else if (secim == "8")
                    {
                        toplam = toplam + 92;
                    }
                    else if (secim == "9")
                    {
                        toplam = toplam + 179;
                    }
                    else if (secim == "10")
                    {
                        toplam = toplam + 74;
                    }
                    else if (secim == "11")
                    {
                        toplam = toplam + 64;
                    }
                    else if (secim == "12")
                    {
                        toplam = toplam + 157;
                    }
                    else
                        Console.WriteLine("Böyle bir kitap numarası bulunmamaktadır.");
                        Console.WriteLine();
                        Console.WriteLine("Başka bir kitap almak ister misiniz: ");
                        string cevap;
                        cevap = Console.ReadLine();
                        if(cevap=="h" || cevap=="H" || cevap=="hayır" || cevap=="HAYIR")
                            break;
     
                }
                Console.WriteLine("Toplam tutar: " + toplam);
            }





            Console.Read();

        }

    }
}
