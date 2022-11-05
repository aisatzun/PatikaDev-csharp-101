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

//---  hackerrank
//  class Result
// {    /*
//      * Complete the 'plusMinus' function below.
//      *
//      * The function accepts INTEGER_ARRAY arr as parameter.
//      */

//     public static void plusMinus(List<int> arr)
//     {
//      double positiveCount = 0, negativeCount = 0, zeroCount = 0;
//         foreach (var item in arr)
//         {
//          if (item < 0)
//           {
//              negativeCount++;
//           }
//          else if (item > 0)
//           {
//              positiveCount++;                   
//           }
//          else if(item==0)
//           {
//              zeroCount++;                 
//           }
//          }
//              Console.WriteLine("{0:0.000000}", (positiveCount / arr.Count));
//              Console.WriteLine("{0:0.000000}", (negativeCount / arr.Count));
//              Console.WriteLine("{0:0.000000}", (zeroCount / arr.Count));
//     }
// }

// class Solution
// {    public static void Main(string[] args)
//     {
//         int n = Convert.ToInt32(Console.ReadLine().Trim());

//         List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//         Result.plusMinus(arr);
//     }
// }
