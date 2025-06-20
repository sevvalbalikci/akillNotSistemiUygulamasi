
int[] notlar = new int[6];
int toplam = 0;

for (int i = 0; i < 6;i++)
{
    Console.Write((i+1) + " notu girin : ");
    notlar[i] = Convert.ToInt32(Console.ReadLine());
    toplam = notlar[i];
}

double ortalama = (double)toplam / notlar.Length;
Console.WriteLine("Ortalama : " + ortalama);