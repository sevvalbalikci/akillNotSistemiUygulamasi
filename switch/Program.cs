//switch/case

/*
Console.Write("Birinci Sayıyı Giriniz : ");
string x = Console.ReadLine();

Console.Write("İkinci Sayıyı Giriniz : ");
string y = Console.ReadLine();

double sayi1 = Convert.ToDouble(x);
double sayi2 = Convert.ToDouble(y);

Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz : + ,  - ,  * ,  / , % ");
Console.Write("İşlem : ");
string islem = Console.ReadLine();

double sonuc = 0;
bool gecerliIslem = true;

switch (islem)
{
    case "+" :
        Console.WriteLine("Sonuç : " + (sayi1 + sayi2));
        break;
    case "-" :
        Console.WriteLine("Sonuç : " + (sayi1 - sayi2));
        break;
    case "*" :
        Console.WriteLine("Sonuç : " + (sayi1 * sayi2));
        break;
    case "/" :
        if (sayi2 != 0)
            Console.WriteLine("Sonuç : " + (sayi1 / sayi2));
        else
            Console.WriteLine("Sıfıra Bölme Hatası");
        break;
    case "%":
        if (sayi2 != 0)
            Console.WriteLine("Sonuç : " + (sayi1 % sayi2));
        else
            Console.WriteLine("Sıfıra Mod Alma Hatası");
        break;
    default:
        Console.WriteLine("Geçersiz işlem seçildi");
        break;
}

*/



//while


Console.WriteLine(" - HESAP MAKİNESİ - ");

while (true)
{
    double sayi1;
    while (true)
    {
        Console.Write("Birinci Sayıyı Giriniz : ");
        string x = Console.ReadLine();
        if (double.TryParse(x, out sayi1)) //string(yazı) şeklindeki veriyi belirli bir veri tipine(mesela int, double, vs.) dönüştürmek için tryParse kullandım.
            break;
        else //bu satırı sayı yerine herhangi bir şey girildiği zaman yeniden sayı girişi yapılması için uyarı verir.
            Console.WriteLine("\nLütfen bir sayı giriniz!\n");
    }

    double sayi2;
    while (true)
    {
        Console.Write("İkinci Sayıyı Giriniz : ");
        string y = Console.ReadLine();
        if (double.TryParse(y, out sayi2)) //string(yazı) şeklindeki veriyi belirli bir veri tipine(mesela int, double, vs.) dönüştürmek için tryParse kullandım.
            break;
        else  //bu satırı sayı yerine herhangi bir şey girildiği zaman yeniden sayı girişi yapılması için uyarı verir.
            Console.WriteLine("\nLütfen bir sayı giriniz!\n");
    }

    string islem = ""; //döngü içinde kullanılabilir hale getirmek için kullanıldı.
    while (true)
    {
        Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz : + ,  - ,  * ,  / , % ");
        Console.Write("İşlem : ");
        islem = Console.ReadLine();

        double sonuc = 0;
        bool gecerliIslem = false;

        switch (islem)
        {
            case "+":
            case "-":
            case "*":
            case "/":
            case "%":
                gecerliIslem = true;
                break;
            default:
                Console.WriteLine("\nLütfen sadece +, -, *, / veya % giriniz.\n");
                continue; //yanlış işlem seçerse döngüyü tekrar başa alacak
        }
        break; //doğru işlem seçerse döngüden çıkacak
    }

    switch (islem)
    {
        case "+":
            Console.WriteLine("Sonuç : " + (sayi1 + sayi2));
            break;
        case "-":
            Console.WriteLine("Sonuç : " + (sayi1 - sayi2));
            break;
        case "*":
            Console.WriteLine("Sonuç : " + (sayi1 * sayi2));
            break;
        case "/":
            if (sayi2 != 0)
                Console.WriteLine("Sonuç : " + (sayi1 / sayi2));
            else
                Console.WriteLine("Sıfıra Bölme Hatası");
            break;
        case "%":
            if (sayi2 != 0)
                Console.WriteLine("Sonuç : " + (sayi1 % sayi2));
            else
                Console.WriteLine("Sıfıra Mod Alma Hatası");
            break;
        default:
            Console.WriteLine("Geçersiz işlem seçildi");
            break;
    }
    Console.WriteLine("\nDevam etmek için ENTER'a basınız, Çıkmak için 'A' tuşuna basınız.");
    string cevap = Console.ReadLine();

    if (cevap.ToLower() == "a")//cevap metni yazıldığında yazılan metni küçültür ve eğer yazan harf ile eşitse dönngüden çıkar.
    {
        break;
    }
}