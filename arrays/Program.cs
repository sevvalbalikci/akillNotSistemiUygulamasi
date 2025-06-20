/*
int[] notlar = new int[6];
int toplam = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write((i + 1) + " notu girin : ");
    notlar[i] = Convert.ToInt32(Console.ReadLine());
    toplam = notlar[i];
}

double ortalama = (double)toplam / notlar.Length;
Console.WriteLine("Ortalama : " + ortalama);
*/


int[] sayilar = { 12, 23, 34, 45, 56 };

int enBuyuk = sayilar[0];
int enKucuk = sayilar[0];

foreach (int sayi in sayilar)
{
    if (sayi < enBuyuk) enBuyuk = sayi;
    if (sayi > enKucuk) enKucuk = sayi;
}
Console.WriteLine("En Büyük Sayı : " + enBuyuk);
Console.WriteLine("En Küçük Sayı : " + enKucuk);











