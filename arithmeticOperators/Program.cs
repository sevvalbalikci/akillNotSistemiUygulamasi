//toplama ,çıkarma, çarpma, bölme, mod alma

/*
int a = 45;
int b = 10;

Console.WriteLine("İki Sayının Toplamı : " + (a + b));
Console.WriteLine("İki Sayının Farkı : " + (a - b));
Console.WriteLine("İki Sayının Çarpımı : " + (a * b));
Console.WriteLine("İki Sayının Bölümü : " + (a / b));
Console.WriteLine("İki Sayının Modu : " + (a % b));
*/

//mod alma

/*
int sayi = 23;
int kalan = sayi % 5;

Console.WriteLine(kalan);  
*/

//ekleme-çıkarma

/*
int x = 2;
Console.WriteLine(x++);
Console.WriteLine(++x);
Console.WriteLine(x);
*/

/*
int y = 5;
Console.WriteLine(y--);
Console.WriteLine(--y);
Console.WriteLine(y);
*/

//ondalık işlem - dönüşüm

/*
int sayi1 = 7;
int sayi2 = 2;

double sonuc = (double) sayi1 / sayi2;
Console.WriteLine(sonuc);
*/



//kullanıcı girişli hesaplama


Console.Write("Birinci Sayı : ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci Sayı : ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Toplam : " + (sayi1 + sayi2));
Console.WriteLine("Fark : " + (sayi1-sayi2));
Console.WriteLine("Çarpma : " + (sayi1*sayi2));
Console.WriteLine("Bölüm : " + (double)(sayi1 / sayi2));



//hesap makinesi (if-else) kullanılan

/*
Console.WriteLine("BASİT HESAP MAKİNESİ");


Console.Write("Birinci Sayıyı Giriniz : ");
string birinciSayi = Console.ReadLine();

Console.Write("İkinci Sayıyı Giriniz : ");
string ikinciSayi = Console.ReadLine();

double sayi1 = Convert.ToDouble(birinciSayi);
double sayi2 = Convert.ToDouble(ikinciSayi);

Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz : + ,  - ,  * ,  / , % ");
Console.Write("İşlem : ");
string islem = Console.ReadLine();

double sonuc = 0;
bool gecerliIslem = true;

if (islem == "+")
    sonuc = sayi1 + sayi2;
else if (islem == "-")
    sonuc = sayi1 - sayi2;
else if (islem == "*")
    sonuc = sayi1 * sayi2;
else if (islem == "/")
{
    if (sayi2 != 0)
        sonuc = sayi1 / sayi2;
    else
    {
        Console.WriteLine("Sıfıra Bölme hatası");
        gecerliIslem = false;

    }
}
else if (islem == "%")
    sonuc = sayi1 % sayi2;
else
{
    Console.WriteLine("Geçersiz işlem seçtiniz.");
    gecerliIslem = false;
}

if (gecerliIslem)
    Console.WriteLine("Sonuç : " + sonuc );

Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa bas.");
Console.ReadLine();
*/
