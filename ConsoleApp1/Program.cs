//liste şeklinde

/*
string[] hayvanlar = {"Kedi", "Kuş", "Köpek" };
foreach (string hayvan in hayvanlar)
{
    Console.WriteLine(hayvan);
}
*/


/*
string[] liste = { "Ekmek", "Süt", "Peynir", "Yumurta" };

Console.WriteLine("Alışveriş Listesi:");
foreach (string urun in liste)
{
    Console.WriteLine("- " + urun);
}
*/


int [] sayilar  = { 3, 6, 9, 11, 12, 15 };
int tekAdet = 0;
foreach (int sayi in sayilar)
{
    if (sayi % 2 != 0)
        tekAdet++;
}
Console.WriteLine("Tek Sayı adeti = " + tekAdet);



