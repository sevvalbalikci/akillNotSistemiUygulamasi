using System;

class Program
{
    static string[] adlar = new string[100];
    static int[] vizeler = new int[100];
    static int[] finaller = new int[100];
    static double[] ortalamalar = new double[100];
    static bool[] durumlar = new bool[100];
    static int ogrenciSayisi = 0;
    static int notGirilenOgrenciSayisi = 0;
    static int[] ogrenciNumaralari = new int[100];
    static int ogrenciNoSayaci = 10000; 

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---AKILLI NOT SİSTEMİ---");
            Console.WriteLine("A - Öğrenci ekle");
            Console.WriteLine("B - Notları Gir");
            Console.WriteLine("C - Ortalama Hesapla");
            Console.WriteLine("D - Öğrencileri Listele");
            Console.WriteLine("E - Öğrencilerin Ders Durumları");
            Console.WriteLine("F - Çıkış");

            Console.Write("Seçiminiz : ");
            string secim = Console.ReadLine().ToUpper();

            switch (secim)
            {
                case "A":
                    OgrenciEkle();
                    break;
                case "B":
                    NotGir();
                    break;
                case "C":
                    OrtalamaHesapla();
                    break;
                case "D":
                    Listele();
                    break;
                case "E":
                    DersDurumuListele();
                    break;
                case "F":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }

            Console.WriteLine("\nDevam etmek için 'P / p' tuşuna bas...");
            while (char.ToUpper(Console.ReadKey(true).KeyChar) != 'P')
            {
                Console.WriteLine("Lütfen sadece 'P / p' tuşuna basın!");
            }
        }
    }

    static void OgrenciEkle()
    {
        while (true)
        {
            Console.Write("Öğrencinin Adını ve Soyadını Giriniz : ");
            string tamAd = Console.ReadLine();


            bool gecerli = true;
            foreach (char c in tamAd)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    gecerli = false;
                    break;
                }
            }

            if (gecerli && tamAd.Length > 0)
            {
                adlar[ogrenciSayisi] = tamAd;
                ogrenciNumaralari[ogrenciSayisi] = ogrenciNoSayaci;
                Console.WriteLine("Öğrenci No: " + ogrenciNoSayaci + " olarak eklendi.");
                ogrenciSayisi++;
                ogrenciNoSayaci++; 
                break;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece harf ve boşluk kullanın.");
            }
        }
    }

    static void NotGir()
    {
        for (int i = notGirilenOgrenciSayisi; i < ogrenciSayisi; i++)
        {
            Console.WriteLine(adlar[i] + " öğrencisi için notları girin:");

            while (true)
            {
                Console.Write("Vize (0-100): ");
                bool basarili = int.TryParse(Console.ReadLine(), out int vizeNot);
                if (basarili && vizeNot >= 0 && vizeNot <= 100)
                {
                    vizeler[i] = vizeNot;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş! Lütfen 0 ile 100 arasında bir sayı girin.");
                }
            }

            while (true)
            {
                Console.Write("Final (0-100): ");
                bool basarili = int.TryParse(Console.ReadLine(), out int finalNot);
                if (basarili && finalNot >= 0 && finalNot <= 100)
                {
                    finaller[i] = finalNot;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş! Lütfen 0 ile 100 arasında bir sayı girin.");
                }
            }
        }

        notGirilenOgrenciSayisi = ogrenciSayisi;
    }

    static void OrtalamaHesapla()
    {
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            ortalamalar[i] = vizeler[i] * 0.4 + finaller[i] * 0.6;
            durumlar[i] = ortalamalar[i] >= 50;
        }

        Console.WriteLine("Ortalama Hesaplandı.");
    }

    static void Listele()
    {
        if (ogrenciSayisi == 0)
        {
            Console.WriteLine("Henüz Öğrenci Eklenmedi.");
            return;
        }

        Console.WriteLine("\n--- ÖĞRENCİ LİSTESİ ---");
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            Console.WriteLine((i + 1) + ". Öğrenci No: " + ogrenciNumaralari[i] + " - " + adlar[i]);
        }
    }

    static void DersDurumuListele()
    {
        if (ogrenciSayisi == 0)
        {
            Console.WriteLine("Henüz öğrenci yok.");
            return;
        }

        Console.WriteLine("\n--- DERS DURUMU ---");
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            string durum;
            if (ortalamalar[i] >= 50)
                durum = "Geçti";
            else
                durum = "Kaldı";
            string harfNotu = NotHarfiniHesapla(ortalamalar[i]);
            Console.WriteLine(adlar[i] + " , Vize: " + vizeler[i] + ", Final: " + finaller[i] + " - Ortalama: " + ortalamalar[i].ToString("F2") + " - " + durum);
        }
    }

    static string NotHarfiniHesapla(double ortalama)
    {
        if (ortalama >= 90) return "AA";
        else if (ortalama >= 85) return "BA";
        else if (ortalama >= 80) return "BB";
        else if (ortalama >= 75) return "CB";
        else if (ortalama >= 70) return "CC";
        else if (ortalama >= 65) return "DC";
        else if (ortalama >= 60) return "DD";
        else if (ortalama >= 50) return "FD";
        else return "FF";
    }
}
