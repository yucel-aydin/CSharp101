#region Değişkenler ve Veri Tipleri
// byte b = 5; // 1 byte
// sbyte sb = 5;// 1 byte

// short s = 5;// 2 byte
// ushort us = 5;// 2 byte

// Int16 i16 = 5;// 2 byte
// int i = 2;// 4 byte
// uint ui = 2; // 4 byte
// Int32 i32 = 2;// 4 byte
// Int64 i64 = 2;// 4 byte

// long l = 5; // 8 byte
// ulong ul = 5; // 8 byte

// float f = 1.1f; // 4 byte
// double d = 1.1; // 8 byte
// decimal de = 5; // 16 byte

// char ch = '2'; // 2 byte
// string str = "Bahattin"; //sınırsız

// bool b1 = true;//1 byte
// bool b2 = false;//1 byte

// DateTime dt = DateTime.Now;
// Console.WriteLine(dt);

// object o1 = "x";
// object o2 = 'y';
// object o3 = 4;
// object o4 = 4.3;

// string ifadeler
// string str1 = string.Empty;
// str1 = "Zikriye Ürkmez";
// string ad = "Zikriye";
// string soyad = "Ürkmez";
// string tamIsim = ad + " " + soyad;

// integer tanımlama şekilleri

// int integer1 = 5;
// int integer2 = 3;
// int integer3 = integer1 * integer2;

// Boolean
// bool bool1 = 10 > 2;

// Değişken Dönüşümleri
// string str20 = "20";
// int int20 = 20;
// string yeniDeger = str20 + int20.ToString();
// Console.WriteLine(yeniDeger);

// int int21 = int20 + Convert.ToInt32(str20);
// Console.WriteLine(int21);

// int int22 = int20 + int.Parse(str20);

// string datetime = DateTime.Now.ToString("dd.MM.yyyy");
// Console.WriteLine(datetime);

// string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
// Console.WriteLine(datetime2);

// string hour = DateTime.Now.ToString("HH:mm");
// Console.WriteLine(hour);
#endregion

#region Operatörler
// Console.WriteLine("*****Atama ve işlemli atama*****");
// Atama ve işlemli atama
// int x = 3;
// int y = 3;
// y = y + 2;

// Console.WriteLine(y);
// y += 2;
// Console.WriteLine(y);
// y /= 1;
// Console.WriteLine(y);
// x *= 2;
// Console.WriteLine(x);

// Console.WriteLine("*****Mantıksal Operatörler*****");
// Mantıksal Operatörler
// ||, &&, !

// bool isSuccess = true;
// bool isCompleted = false;

// if (isSuccess && isCompleted)
//     Console.WriteLine("Perfect!");

// if (isSuccess || isCompleted)
//     Console.WriteLine("Great!");

// if (isSuccess || !isCompleted)
//     Console.WriteLine("Fine!");

// Console.WriteLine("*****İlişkisel Operatörler*****");
// İlişkisel Operatörler
// <, >, <=; >=; ==; !=

// int a = 3;
// int b = 4;
// bool sonuc = a < b;

// Console.WriteLine(sonuc);
// sonuc = a > b;
// Console.WriteLine(sonuc);
// sonuc = a >= b;
// Console.WriteLine(sonuc);
// sonuc = a <= b;
// Console.WriteLine(sonuc);
// sonuc = a == b;
// Console.WriteLine(sonuc);
// sonuc = a != b;
// Console.WriteLine(sonuc);

// Console.WriteLine("*****Aritmetik Operatötler*****");
// Aritmetik Operatötler
// /, *, +, -

// int sayi1 = 10;
// int sayi2 = 5;
// int sonuc1 = sayi1 / sayi2;
// Console.WriteLine(sonuc1);
// sonuc1 = sayi1 * sayi2;
// Console.WriteLine(sonuc1);
// sonuc1 = sayi1 + sayi2;
// Console.WriteLine(sonuc1);
// sonuc1 = sayi1++;
// Console.WriteLine(sayi1);

// % : mod alır
// int sonuc2 = 20 % 3;
// Console.WriteLine(sonuc2);

#endregion

#region Tip Dönüşümleri
// // Implicit Conversion (Bilinçsiz Dönüşüm)
// Console.WriteLine("*****Implicit Conversion*****");

// byte a = 5;
// sbyte b = 30;
// short c = 10;

// Convert.ToInt32(a);
// int d = a + b + c;
// Console.WriteLine("d!" + d);

// long h = d;
// Console.WriteLine("h!" + d);

// float i = h;
// Console.WriteLine("i!" + d);

// string e = "burak";
// char f = 'k';
// object g = e + f + d;
// Console.WriteLine("g:" + g);

// //Explicit Conversion (Bilinçli Dönüşüm)

// Console.WriteLine("*****Explicit Conversion*****");

// int x = 4;
// byte y = (byte)x;
// Console.WriteLine("y:" + y);

// int z = 100;
// decimal ssd=0;
// ssd=z;

// byte t = (byte)z;
// Console.WriteLine("t:" + t);

// float w = 10.3f;
// byte v = (byte)w;
// Console.WriteLine("v:" + v);

// // ToString Methodu
// Console.WriteLine("*****Explicit Conversion*****");
// int xx = 6;
// string yy = xx.ToString();
// Console.WriteLine("yy:" + yy);

// string zz = 12.5f.ToString();
// Console.WriteLine("zz:" + zz);

// //System Convert Sınıfı
// Console.WriteLine("*****System Convert Sınıfı*****");

// string s1 = "10", s2 = "20";
// int sayi1, sayi2;
// int Toplam;

// sayi1 = Convert.ToInt32(s1);
// sayi2 = Convert.ToInt32(s2);

// Toplam = sayi1 + sayi2;
// Console.WriteLine("Toplam:" + Toplam);

// //Parse Methodu
// Console.WriteLine("*****Parse Methodu*****");
// ParseMethod();

// static void ParseMethod()
// {
//     string metin1 = "10";
//     string metin2 = "10,25";
//     int rakam1;
//     double double1;

//     rakam1 = Int32.Parse(metin1);
//     double1 = Double.Parse(metin2);

//     Console.WriteLine("rakam1 :" + rakam1);
//     Console.WriteLine("double1 :" + double1);


// }
#endregion

#region Try-Catch-Finally ve Mantıksal Hatalar
try
{
    int a = int.Parse(Console.ReadLine());

    int b = int.Parse(Console.ReadLine());

    int c = a + b;

    Console.WriteLine(c);
}
catch (Exception ex)
{
    Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");
}
#endregion

#region Karar Yapıları - If-ElseIf-Ternary-If
int time = DateTime.Now.Hour;

if (time >= 6 && time < 11)
    Console.WriteLine("Günaydın.");
else if (time <= 18)
    Console.WriteLine("İyi günler.");
else
    Console.WriteLine("İyi geceler.");

string sonuç = time <= 18 ? "İyi günler." : "İyi geceler.";

sonuç = time >= 6 && time < 11 ? "Günaydın." : time <= 18 ? "İyi günler." : "İyi geceler.";
Console.WriteLine(sonuç);
#endregion

#region Karar Yapıları -Switch-Case
int month = DateTime.Now.Month;

switch (month) //Kontrol etmek istediğimiz koşulu yazarız.
{
    case 1:
        Console.WriteLine("Ocak ayındasınız.");
        break;
    case 2:
        Console.WriteLine("Şubat ayındasınız.");
        break;
    case 3:
        Console.WriteLine("Mart ayındasınız.");
        break;
    case 4:
        Console.WriteLine("Nisan ayındasınız.");
        break;
    case 5:
        Console.WriteLine("Mayıs ayındasınız.");
        break;
    case 6:
        Console.WriteLine("Haziran ayındasınız.");
        break;
    case 7:
        Console.WriteLine("Temmuz ayındasınız.");
        break;
    case 8:
        Console.WriteLine("Ağustos ayındasınız.");
        break;
    case 9:
        Console.WriteLine("Eylül ayındasınız.");
        break;
    case 10:
        Console.WriteLine("Ekim ayındasınız.");
        break;
    case 11:
        Console.WriteLine("Kasım ayındasınız.");
        break;
    case 12:
        Console.WriteLine("Aralık ayındasınız.");
        break;

    default: //Hiçbir case olmazsa yapılacak olan işlemi ifade eder.
        Console.WriteLine("Yanlış veri girdiniz.");
        break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış ayındasınız.");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("Bahar ayındasınız.");
        break;

    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz ayındasınız.");
        break;

    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar ayındasınız.");
        break;

    default:
        break;
}

#endregion

#region Döngüler- For Loop ve Break Continue Ifadeleri
// 1'den başlayarak ekrandan girilen sayıya kadar tek olan sayıları yazdıran program.
Console.Write("Bir sayı giriniz:");
int sayaç = int.Parse(Console.ReadLine());
for (int i = 1; i <= sayaç; i++) // i 0'dan başlayarak her döngü içerisinde bir arttırarak length'ten küçük olana kadar bu for döngüsü dönecek.
{
    if (i % 2 == 1)
        Console.WriteLine(i);
}

// 1 ile 1000 arasındaki tek ve çift sayıları toplayıp console yazdıran program
int tekToplam = 0;
int çiftToplam = 0;
for (int i = 1; i <= 1000; i++)
{
    if (i % 2 == 1)
        tekToplam += i; // tekToplam = tekToplam + i;
    else
        çiftToplam += i; // çiftToplam = çifToplam + i;
}
Console.WriteLine("Tek Toplam: " + tekToplam);
Console.WriteLine("Çift Toplam: " + çiftToplam);

// break ve continue terimleri
// Eğer bir döngü içinde bir case bağlı olarak döngüyü sonlandırmak istiyorsak break kullanılır.
// Eğer bir şarta bağlı olarak mevcut döngünün o cycle'ını atlamak istiyorsak continue kullanılır. 

for (int i = 1; i < 10; i++) // 1'den başladı 10'a kadar gidecekti ama koşul sağlanınca döngü sonlandı.
{
    if (i == 4)
        break;
    Console.WriteLine(i);
}

for (int i = 1; i < 10; i++) // 1'den başladı 10'a kadar gitti fakat koşulun sağlandığı kısmı atladı ve döngüye devam etti sonlandırdı.
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}

// break o an içinde olduğu durumu sonlandırır. 
// Eğer içiçe loop varsa iç içe break ifadesi kullanılmışsa tüm loop sonlanmaz,
// orası devam eder ve en iç loop sonlanır.
#endregion

#region  Döngüler- While ve ForEach

// Koşullar sağlandıkça komut satırlarının çalıştırılmasını sağlar. For döngüsünden farklı olarak iterasyon sayısı belli değildir.
int sayac = 1;
while (sayac <= 5)
{
    Console.WriteLine(sayac);
    sayac++;
}
int[] sayiDizisi = {2,4,5,1,2,4};
int toplam = 0 ;
// Foreach döngüsü diziler ve koleksiyonlarla döngüsel işlemler yapmak için kullanılır. Yapısı while ve for döngüsünden biraz farklıdır. Döngünün ne kadar devam edeceğini kullanılan dizi veya koleksiyonun eleman sayısı belirler. Her bir elaman için bir iterasyon gerçekleşir.
foreach(int i in sayiDizisi)
{
    toplam += i ;
}
#endregion