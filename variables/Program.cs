// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 byte b =   5;    // 1 byte  0-255             
 sbyte c = 2;     // 1 byte  -128 / +127           
 short s= 3;      // 2 byte  -32.00 / +32.000   
 ushort us= 5;    // 2 byte  0 /  65000  
            
Int16 i16_ = 2;   // 2 byte 
int  i = 4;       // 4 byte
Int32  i32 = 2;   // 4 byte            
Int64  i64 = 3;   // 8 byte 

long l = 3;       // 8 byte 
ulong ul= 5;      // 8 byte 

float  f = 4;     // 4 byte 
double  d  = 5;   // 8 byte 
decimal  de = 5;  // 16 byte 

char ch='a';      // 2 byte
string str = "Aisa"; //Sınırsız karakter tutabilir.

bool b1 = true; //TRUE FALSE 
DateTime dt = DateTime.Now; // bugünün tarihini verir.
Console.WriteLine(dt);

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.5;

string str1 = string.Empty;
string str2 = null;

int x= 15;
string y= "2";

Console.WriteLine(y + x.ToString());
Console.WriteLine(x + Convert.ToInt32(y));

int x01 = x + int.Parse(y);
Console.WriteLine( x01);

string datetime2 = DateTime.Now.ToString("dd.MM.yyyy");
 Console.WriteLine(datetime2);

string hour = DateTime.Now.ToString("HH.mm");
Console.WriteLine(hour);