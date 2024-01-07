﻿# region Degiskenler

// DRY: Do not Repeat Yourself
//mccall software quality model

//var yil=2023;//derlemede aşamasında veri tipini kendisi belirliyor.

//Type safety, tip güvenli
//Bellekte kaplaycagı  alabı  onceden ayırmıs oluyoruz hem de, alabileceği  dğerleri ve aralıgını belirlemis oluyoruz

//ilkel/değer tip 
//int yil=2023; // 32-bit  ~- 2.1mr - ~2.1mr // default değeri= 0 (ondalik) // 00000000(ikilik)
//short yil=2023; //16-bit  ~-32bin - ~32bin

ushort yil =2023; //unsigned // 16-bit 0 - ~65bin //default değeri= 0

byte yas =0;//0-255 //default değeri= 0
long hesapla = 999999999999;//64 bit //default = 0

// float dolarKuru = 29.06f; //32-bit //default = 0
double dolarKuru = 29.065593; // 64-bit //default = 0

decimal hesaplamaSonucu = 29.065m; //128-bit //default = 0

bool giris = true; // 1-bit // // default değeri= false

char karakter = 'A'; //65 //Ek bilgi: Unicode ASCII tablolarına gore 65 // 16-bit // default değeri= 0 veya null //ASCII U+0000(NULL)

//String aslında bir referans tip, ilkel/değer tip 
string isim = "Ahmet"; // 32-bit // 16mr-bite kadar genisleyebilir //default= null

char sayi2 = default;
Console.WriteLine(sayi2);// 0(ondalik) // 00000000(ikilik)

string? takmaAd = null;
if (takmaAd != null)
    Console.WriteLine(takmaAd.ToUpper()); // takmaAd null ise ToUpper metodunu çalıştırmaya çalışmayacak ve null değerini bize verecek.

Console.WriteLine(takmaAd?.ToUpper()); // takmaAd null ise ToUpper metodunu çalıştırmaya çalışmayacak ve null değerini bize verecek.

Console.WriteLine(takmaAd ?? "Takma ismi bulunmuyor"); // takmaAd null ise sağdaki değeri bize verecek.


int sayi1 = 10;
int say2 = 20;
int sayi3 = 30;
int sonuc = sayi1 + sayi2* sayi3;

string isim2 = "Ahmet";
string soyad = " Çetinkaya";
string tamIsim=isim2 + "" +soyad;

bool durum1 = true;
bool durum2 = false;
bool sonDurum = durum1 && durum2; // false
bool sonDurum2 = durum1 || durum2; // true 


int tamSayi =10;
double ondalikliSayi = tamSayi; //10.0 //Implisit (bilinçsiz tür dönüşümü)

double ondalikliSayi2 = 10.5;
// int tamSayi2 = ondalikliSayi2; // Veri kaybı olacağı için implist şekilde tür dönüşümü yapacaktır.
int tamSayi2 = (int)ondalikliSayi2;//Explist (bilinçli) tür dönüşümü 

long buyukTamSayi = long.MaxValue; //64-bit
int normalTamSayi = (int)buyukTamSayi; //64-bit -> 32-bit /Hata:-1

// int normalTamSayi2 = Convert.ToInt32(buyukTamSayi); // Error:değer int'e göre ço k büyük
string metinselTamSayi = buyukTamSayi.ToString();

//bool 2OndalıkSayi //Invalid
//double ondaklik_sayi=long.MaxValue; //Valid
//double @double =double.MaxValue;
//double ondalik sayi =long.MaxValue;//Invalid

#endregion 

