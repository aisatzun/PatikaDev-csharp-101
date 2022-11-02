// Implicit Conversion (Bilinçsiz Dönüşüm)
Console.WriteLine("*****Implicit Conversion ");

byte  a = 5;
sbyte b = 30;
short c = 10;

int d =a+b+c;
Console.WriteLine("d:"+d);

long  h = d;
float i = h;

string e="aisa";
char f ='t';
object g=e+f+d;
Console.WriteLine("g :"+g);

// Explicit Conversion (Bilinçli dönüşüm)   
Console.WriteLine("*****Explicit Conversion ");

int  x = 4;
byte y = (byte)x;
Console.WriteLine("y :"+y);

float w = 10.3f;
byte  v = (byte)w;
Console.WriteLine("v :"+v);

// *** ToString Method ***
Console.WriteLine("*** ToString Method *** ");

int   xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy :"+yy);

string zz=12.5f.ToString();
Console.WriteLine("zz :" +zz);

// System.Convert
Console.WriteLine("*** System.Convert *** ");

string s1="10",s2="20";
int sayi1,sayi2;
int toplam;

sayi1=Convert.ToInt32(s1);
sayi2=Convert.ToInt32(s2);

toplam=sayi1+sayi2;
Console.WriteLine("toplam :"+toplam);

// Parse
Console.WriteLine("*** Parse  *** ");

string m1="10";
string m2="10.25";
int  r1;
double d1;

r1 = Int32.Parse(m1);
d1 = Double.Parse(m2);

Console.WriteLine("r1 :"+r1);
Console.WriteLine("d1 :"+d1);