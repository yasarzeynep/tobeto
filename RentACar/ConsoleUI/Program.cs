#region Degiskenler

// DRY: Do not Repeat Yourself
// mccall software quality model

//var yil=2023;//derlemede aşamasında veri tipini kendisi belirliyor.

//Type safety, tip güvenli
//Bellekte kaplaycagı  alabı  onceden ayırmıs oluyoruz hem de, alabileceği  dğerleri ve aralıgını belirlemis oluyoruz

//ilkel/değer tip 
using System;
using System.Globalization;

int yil=2023; // 32-bit  ~- 2.1mr - ~2.1mr // default değeri= 0 (ondalik) // 00000000(ikilik)
//short yil = 2023; //16-bit  ~-32bin - ~32bin

//ushort yil = 2023; //unsigned // 16-bit 0 - ~65bin //default değeri= 0

byte yas = 0;//0-255 //default değeri= 0
long hesapla = 999999999999;//64 bit //default = 0

float dolarKuru = 29.06f; //32-bit //default = 0
//double dolarKuru = 29.065593; // 64-bit //default = 0

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
int sonuc = sayi1 + sayi2 * sayi3;

string isim2 = "Ahmet";
string soyad = " Çetinkaya";
string tamIsim = isim2 + "" + soyad;

bool durum1 = true;
bool durum2 = false;
bool sonDurum = durum1 && durum2; // false
bool sonDurum2 = durum1 || durum2; // true 


int tamSayi = 10;
double ondalikliSayi = tamSayi; //10.0 //Implisit (bilinçsiz tür dönüşümü)

double ondalikliSayi2 = 10.5;
//int tamSayi2 = ondalikliSayi2; // Veri kaybı olacağı için implist şekilde tür dönüşümü yapacaktır.
//int tamSayi2 = (int)ondalikliSayi2;//Explist (bilinçli) tür dönüşümü 

long buyukTamSayi = long.MaxValue; //64-bit
int normalTamSayi = (int)buyukTamSayi; //64-bit -> 32-bit /Hata:-1

//int normalTamSayi2 = Convert.ToInt32(buyukTamSayi); // Error:değer int'e göre çok büyük
string metinselTamSayi = buyukTamSayi.ToString();

//bool 2OndalıkSayi //Invalid
double ondaklik_sayi=long.MaxValue; //Valid
double @double = double.MaxValue;
//double ondalik sayi =long.MaxValue;//Invalid
//long cokBuyukTamSayi =long.MaxValue+1;//Overflow error
long cokBuyukTamSayi = long.MaxValue;//Overflow error
Console.WriteLine(cokBuyukTamSayi + 1);// Sayımız ilgili veri tipinin MinValue değerine geri döner.
#endregion

#region Koşullu İfadeler
bool durum3 = false;
bool durum4 = true;
if (durum3)
    Console.WriteLine("Durum3 Geçerli");
if (durum3)
{
    Console.WriteLine("Durum3 Geçerli");
}
else if(durum4)
{
    Console.WriteLine("Durum4 Geçerli");
}
else
{
    Console.WriteLine("Durumlar Geçersiz");
}
string komut = "delete";
if (komut == "add" || komut == "update")
    Console.WriteLine("Ekleme işlemi tamamlandı");
else if (komut == "delete")
    Console.WriteLine("Silme işlemi tamamlandı");

switch  (komut)
{
    case "add":
    case "update":
        Console.WriteLine("Ekleme işlemi tamamlandı");
        break;
    case "delete":
        Console.WriteLine("Silme işlemi tamamlandı");
        break;
    default: //Son işlem burda yapılabilir.
        Console.WriteLine("Geçersiz işlem.");
        break;
}
string mesaj; // default:null
if (komut == "add" || komut == "update")
    mesaj = "Ekleme işlemi tamamlandı";
else if (komut == "delete")
    mesaj = "Silme işelemi tamamlandı";
 mesaj = komut == "add" ? "Ekleme işlemi tamamlandı" //ternary  operator
    : komut == "delete" ? "Silme işlemi tamamlandı"
    : "Geçersiz işlem.";

 mesaj = komut switch
{
    "add" => "Ekleme işlemi tamamlandı",
    "update" => "Silme işlemi tamamlandı",
    _ => "Geçersiz işlem."
};
Console.WriteLine(mesaj);

#endregion

#region Döngüler

int sayi4 = 10;
int sayi5 = sayi4++;

int birArtirir(int sayi)
{
    int temp = sayi;
    sayi = sayi + 1;
    return temp;
}
int sayi6 = ++sayi4;

int önceBirArtirir(int sayi)
{
    sayi = sayi + 1;
    return sayi;
}
//int sayi6 = ++sayi4;
//Console.WriteLine(sayi6);

//Console.WriteLine(sayi5);
//Console.WriteLine(sayi4);

for (int index = 0; // Döngünün en başında bir kez çalışır
     index < 10; // Her döngünün başında kontrol ettiğimiz koşul
      ++index  //index++ //index=index+1 //Her döngünün sonunda çalışan ayama komutumuz
        ) 
{
    //int index=0;
    //index<10;
    //İşlemler
    //index=++index;
    if (index == 5)
        continue; //Bir döngü adımına geçmeden bir sonraki  döngü adımına geçer.
    if (index == 7)
        break; //Döngü sürecini tamamen bitirir.

    //for(int i = 0; i < 10; ++i)
    //{ if (i == 0) continue;}
    Console.WriteLine(index);
}
int index2 = 0;
while( index2 < 10)
{
    // if (index2 == 5) continue; //Sonsuz döngü oluşturmuş oluruz.
    if (index2 == 5)
    {
        index2 += 1;
        continue;
    }
    Console.WriteLine(index2);
    index2 += 1;
}

//while (true) //Sonsuz döngülerden her saim kacınmamız gerekiyor, çünkü program o noktada yıkanacaktır
//{
//İstisna durumlarda sürekli  kontrol için sonsuz düngüler oluşturulabilir.Fakat programı aksatmayacak şekilde olmalıdır
//}

do
{
    // Döngünün ilk adımında herhangi bir koşula tabi olmadan ilgili işlemler yapılır
    // Döngünün sonraki adımlarında
} while (false); // Her döngünün sonunda kontrol ettiğimiz koşul
Console.WriteLine("Program Bitti.");
#endregion

#region Metot ve Fonksiyonlar
//[Döndürülen değerin veri tipi] [METOTUN İSMİ] ( [PARAMETERLER] ) { }
void yazdir(string icerik)
{
    
    Console.WriteLine(icerik); //Printer'a içeriği yazdıran fonksiyon olarak düşünebiliriz.
}
//Fonksiyon
int topla (
    // Parametre tanımlama özellikleri
    int sayi1, //Zorunlu parametre
    int sayi2=0, //Opsiyonel parametre //En son olcak sekilde kullanabiliriz
     int sayi3 = 10
    ) 
{
    int toplamaSonuc = sayi1 + sayi2;
    //..
    //..

    return toplamaSonuc;
} //Modülerlik 

//Fonksiyonlarda overload yok, metotlarda yapılabilir

// Parametre verme biçimleri
int sonuc1 = topla(50,10); // Paramete pozisyon bazlı parametre geçtik
int sonuc2= topla(sayi2:40, sayi1:30); //Tekrar kullanılabilir //Okunabilirlik //parametre isim bazlı parametre

yazdir(sonuc.ToString());//Pozisyon bazlı parametre
yazdir(icerik:sonuc.ToString());//parametre isim bazlı parametre

//Params
int hepsiniTopla(
    // Parametre tanımlama özellikleri
    int baslangicSayisi, params int[] sayilar)// params sadece bir tane ve en son olacak şekilde kullanabiliriz.
{
    int toplam = baslangicSayisi;
    foreach (int sayi in sayilar)
    {
        toplam += sayi;
    }
 return toplam;
}
int sonuc3=hepsiniTopla(0, 10, 20, 30, 40, 50);

//ref, aut  // Temel //İlkel veri tipleri üzerinde kullanılır.
#endregion