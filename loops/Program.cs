//for loop

/*
for (int sayi = 2; sayi <= 100; sayi++)
{
    bool asalMı = true;

    for(int i=2; i<=sayi;i++)
    {
        if(sayi % 2 == 0)
        {
            asalMı=false;
            break;
        }
    }
    if (asalMı)
        Console.WriteLine(sayi + " asaldır sayıdır.");
}
*/

//do-while loop

/*
int sayi;
int toplam = 0;

do
{
    Console.Write("Bir Sayı Girin : ");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;
}while(toplam <= 100);

Console.WriteLine("Toplam 100'ü geçti.Toplam : " + toplam);
*/

//foreach

/*
using System.Transactions;

string[] isimler = { "Kerem", "Şevval" , "Aylin", "Umut", "Sevgi"};

foreach (string isim in isimler)
{
    if(isim.ToLower().Contains('e'))
    {
        Console.WriteLine(isim + " isminde 'e' harfı vardır ");
    }
}*/


//while

/*
int satir = 1;
while (satir <= 10)
{
    int sayi = 1;
    while (sayi <= satir)
    {
        Console.Write(sayi + " ");
        sayi++;
    }
    Console.WriteLine();
    satir++;
}
*/


//if-else



















