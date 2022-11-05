// See https://aka.ms/new-console-template for more information

//--- array

string[] renkler = new string[5];

string[] hayvanlar = {"Kedi","Kopek","Kuş","Maymun"};
int[] dizi;
dizi=new int[5];

//--- Diziler değer atama ve erişim
renkler[0]="Mavi";
dizi[3]=10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// Döngülerle dizi kullanımı
// Klavyeden girilen n tane sayının ortalamasını hesaplayan program

Console.WriteLine("Dizinin elaman sayısını giriniz");
int diziUzunluk = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunluk];

for(int i=0;i<diziUzunluk;i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ",i+1);
    sayiDizisi[i] =int.Parse(Console.ReadLine());
}

int toplam=0;
foreach ( var sayi in sayiDizisi)
{
    toplam+=sayi;

    Console.WriteLine("Ortalama :"+ toplam/diziUzunluk);
}
