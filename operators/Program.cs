// See https://aka.ms/new-console-template for more information
//vs code

Console.WriteLine("**** Atama ve İşlemli Atama Operatörler "); 
//--- Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
int x=5;
int y=10;
y = y+2;
int sum = x+y;

//  sum = x*y;
//  sum = y-x;
//  sum = y/x;
Console.WriteLine(sum);

Console.WriteLine("****Mantıksal Operatörler "); 
//--- Mantıksal Operatörler (||, &&, !)

bool isSuccess = true;
bool isCompleted = false;

if (isSuccess&&isCompleted)
{
Console.WriteLine("Perfect!");
}
 if (isSuccess || isCompleted)
 {
  Console.WriteLine("Great");
 }
 if (isSuccess&& !isCompleted)
 {
  Console.WriteLine("Fine");
 }

Console.WriteLine("****İlişkisel Operatörler "); 
 //İlişkisel Operatörler (==,!=, <, >, >=,<=)
 int a=3;
 int b=4;

 bool sonuc=a<b;

Console.WriteLine(sonuc);
sonuc= a<b;
Console.WriteLine(sonuc); 
sonuc=a>=b;
Console.WriteLine(sonuc);
sonuc=a<=b; 
Console.WriteLine(sonuc); 
sonuc=a==b;
Console.WriteLine(sonuc); 
sonuc=a!=b;
Console.WriteLine(sonuc); 


Console.WriteLine("****Aritmetik Operatörler"); 

int s1 = 10;
int s2 = 5;
int sonuc1=s1/s2;
Console.WriteLine(sonuc1);
sonuc1=s1+s2;
Console.WriteLine(sonuc1); 
sonuc1=s1*s2;
Console.WriteLine(sonuc1); 
s1++;
Console.WriteLine(s1); 

//mod 
int sonuc2=20%3;
Console.WriteLine(sonuc2); 
