/*
Console.Write("Adınızı girin: ");
string ad = Console.ReadLine();
Console.WriteLine("Merhaba " + ad);
*/

//factoring
/*
string ad = AdAl();
Console.WriteLine("Merhaba" + ad);

string AdAl()
{
    Console.Write("Adınızı giriniz : ");
    return Console.ReadLine();
}
*/


/*
Console.Write("1.Sayıyı giriniz : ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.Sayıyı giriniz : ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi1 + sayi2;
Console.WriteLine("Toplam : " + toplam);
*/

//factoring
/*
int sayi1 = SayiAl("1. sayıyı girin: ");
int sayi2 = SayiAl("2. sayıyı girin: ");
int toplam = sayi1 + sayi2;
Console.WriteLine("Toplam: " + toplam);

int SayiAl(string mesaj)
{
    Console.Write(mesaj);
    return Convert.ToInt32(Console.ReadLine());
}
*/


/*
Console.WriteLine("Vize Notunuzu Giriniz : ");
double vize = Convert.ToDouble(Console.ReadLine());

Console.Write("Final Notunuzu Giriniz : ");
double final = Convert.ToDouble(Console.ReadLine());

double ortalama = vize * (0.4) +  final * (0.6);
Console.WriteLine("Ortalama : " + ortalama);
*/

//factoring


/*
double vize = NotAl("Vize notunuzu giriniz : ");
double final = NotAl("Final notunzuu giriniz : ");
double ortalama = OrtalamaHesapla ( vize , final );
Console.WriteLine("Ortalama: " + ortalama);

double NotAl(string mesaj)
{
    Console.Write(mesaj);
    return Convert.ToDouble(Console.ReadLine());
}

double OrtalamaHesapla(double vize, double final)
{
    return (vize * 0.4) + (final * 0.6);
}
*/


int x1 = SayiAl("Birinci sayıyı gir: ");
int x2 = SayiAl("İkinci sayıyı gir: ");
string islem = IslemAl();

IslemYap(x1, x2, islem);

int SayiAl(string mesaj)
{
    Console.Write(mesaj);
    return Convert.ToInt32(Console.ReadLine());
}

string IslemAl()
{
    Console.Write("İşlem seç (+, -, *, /): ");
    return Console.ReadLine();
}

void IslemYap(int x1, int x2, string islem)
{
    switch (islem)
    {
        case "+":
            Console.WriteLine("Sonuç: " + (x1 + x2));
            break;
        case "-":
            Console.WriteLine("Sonuç: " + (x1 - x2));
            break;
        case "*":
            Console.WriteLine("Sonuç: " + (x1 * x2));
            break;
        case "/":
            if (x2 != 0)
                Console.WriteLine("Sonuç: " + (x1 / x2));
            else
                Console.WriteLine("Hata: 0'a bölünemez.");
            break;
        default:
            Console.WriteLine("Geçersiz işlem");
            break;
    }
}
