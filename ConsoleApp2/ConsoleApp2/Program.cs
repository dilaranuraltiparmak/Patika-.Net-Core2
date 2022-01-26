// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int deger=3;
Console.WriteLine(deger);
byte a=5;  //1 byte
sbyte c=4;  // 1 byte
short s=5;//2 byte
ushort us = 6; // 2 byte
Int16 i16 = 2; // 2 byte
int i = 14; // 4 byte
Int32 i32 = 3; //  4 byte
Int64 İ64 = 0; // 8 BYTE
uint ui = 4; // 4 byte
long l = 8; // 8 byte
//reel sayılar
float f = 4; // 4 byte
double d = 5; //8 byte
decimal dec = 6; //16 byte

char ch = '2'; //tek bir karakter 2 byte ama string sınırsız
string str = "dilara";

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now; //çalıştırıldığı anın saat ve tarihini getirir.
Console.WriteLine(dt);

// her türlü veriyi object ile atayabiliriz aslında bir üst tür gibi düşünülebilir
object o1 = "y";
object o2 = 'a';
object o3 = 3;
object o4=4.3;

//string işlemler
string str1=string.Empty;
str1 = "dilara";
string ad = "dilara";
string soyad = "altıparmak";
string tamad = ad + " " + soyad;

//integer tanımlama işlemleri
int i1 = 3;
int i2 = 5;
int i3 = i1 + i2;


//boolean
bool bool1 = 10 < 11;
//değişken dönüşümleri
string s20 = "20";
int i20 = 20;
string yenideger = s20 + i20.ToString();
Console.WriteLine(yenideger);//string işlemlerinde + yan yana yazdırır çıktısı 2020 olur
 int int21= i20+Convert.ToInt32(s20);
Console.WriteLine(int21);//int işlemlerinde + normal toplama şeklinde çıktı verir 40 çıktısını verdi.

int int22 = i20 + int.Parse(s20);//çıktı 40
string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dateTime);
string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(dateTime2);
string hour= DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);






