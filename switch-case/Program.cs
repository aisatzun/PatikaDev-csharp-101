// See https://aka.ms/new-console-template for more information

int month=DateTime.Now.Month;

// switch(month)
// {
//     case 1:
//         Console.WriteLine("Ocak ayındasınız");
//         break;
//     case 2:
//         Console.WriteLine("Şubat ayındasınız");
//         break;
//     case 3:
//         Console.WriteLine("Mart ayındasınız");
//         break;
//     case 4:
//         Console.WriteLine("Nisan ayındasınız");
//         break;
//     case 11:
//         Console.WriteLine("kasım ayındasınız");
//         break;
//     default:
//         Console.WriteLine("Yanlış veri girildi");
//         break;
// }
// Birden fazla koşulda aynı ifadenin çalışması gereken durumlarda switch-case karar yapıları kullanılır.

switch (month)
    {
        case 12:
        case 1:
        case 2:
            Console.WriteLine("Kış mevsimindeyiz.");
            break;
        case 3:
        case 4:
        case 5:
            Console.WriteLine("İlkbahar mevsimindeyiz.");
            break;
        case 6:
        case 7:
        case 8:
            Console.WriteLine("Yaz mevsimindeyiz.");
            break;
        case 9:
        case 10:
        case 11:
            Console.WriteLine("Sonbahar mevsimindeyiz.");
            break;
        default:
            break;
     
    }

