// See https://aka.ms/new-console-template for more information

//--- while
// Console.WriteLine("Sayı giriniz");
// int sayi=int.Parse(Console.ReadLine());

// int sayac=1;
// int toplam=0;

// while(sayac<=sayi)
// {
//     toplam +=sayac;
//     sayac++;
// }
// Console.WriteLine(toplam/sayi);

// // a dan z ye

// char character='a';
// while(character < 'z')
// {
//     Console.Write(character+" ");
//     character++;
// }

//--- foreach
Console.WriteLine("***  foreach  ***");

string[] arabalar={"Bwm,Ford,Toyota,Nissan"};

foreach(var araba in arabalar)
{
    Console.WriteLine(araba);
}