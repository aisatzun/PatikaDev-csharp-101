// See https://aka.ms/new-console-template for more information

try 
{
Console.WriteLine("Bir sayı giriniz:");
int s1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girmiş olduğunuz sayı:"+s1);
}
catch (Exception ex)
{
  Console.WriteLine("Hata :"+ex.Message.ToString());
}
// finally 
// {
//    Console.Write("İşlem tamamlandı:");
// }

try
{
   // int a = int.Parse(null);
   // int b = int.Parse("test");
      int c = int.Parse("-20012305467");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);    
}
catch (FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil");
    Console.WriteLine(ex);
}
catch(OverflowException ex)
{
    Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz");
    Console.WriteLine(ex);
}

finally{
    Console.WriteLine("işlem tamamlandı");
}
