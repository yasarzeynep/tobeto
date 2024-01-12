#region Degiskenler

// DRY: Do not Repeat Yourself
// mccall software quality model

//var yil=2023;//derlemede aşamasında veri tipini kendisi belirliyor.

//Type safety, tip güvenli
//Bellekte kaplaycagı  alabı  onceden ayırmıs oluyoruz hem de, alabileceği  dğerleri ve aralıgını belirlemis oluyoruz

//ilkel/değer tip 
using ConsoleUI;
using System;
using System.Collections;
using System.Collections.Immutable;
using System.Globalization;
using System.Reflection;
using System.Text;

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

//ref, out // Temel //İlkel veri tipleri üzerinde kullanılır.

//ref; fonksiyona kendi içinde değişken oluşturma, referans ettiğim değişkeni kullan demiş oluyoruz.
void ikiyleCarpımınıDosyaOlarakKaydet(ref int sayi, out int sayi2)
{
    sayi *= 2;
    sayi2 = 1;// out, fonksiyon/Metot içinde ilk atama işlemini verme zorunluğuğu getirir.

    //... bu parametre degiskeninin kullanrak baska islemler, yaptıgını varsayalım
    Console.WriteLine($"ikiyleCarpımınıDosyaOlarakKaydet scope sayi:{sayi}");
}
int sayi = 2;
int sayiOut ;
ikiyleCarpımınıDosyaOlarakKaydet(ref sayi,out sayiOut);
Console.WriteLine($"ana scope sayi: {sayi}" +" "+  $"sayiOut: {sayiOut}");

// Metot
MathHelper mathHelper = new MathHelper(); // referans tip
mathHelper.topla(1, 2);
#endregion

#region Diziler ve Koleksiyonlar

Console.WriteLine("------------Diziler ve Koleksiyon--------------");
// Referans Tip
string[] sira = new string[5]; // 5 dizinin icerisindeki "Sabit" yer sayısı
sira[0] = "Muhammet";
sira[2] = "Umut";

//Console.WriteLine($"sira dizisindeki 2.indexteki degeri {sira[2]}");
for (int index = 0; index < sira.Length; index++)
{
    string siradakiKisininAdı = sira[index];
    Console.WriteLine($"sira dizisindeki {index}.indexteki degeri {siradakiKisininAdı ?? "null"}");
    //string dizide: Console.WriteLine($"sira dizisindeki {index}.indexteki degeri {siradakiKisininAdı ?? "Bos"}");
}
//foreach (var siradakiKisininAdı insira)
//{
//    Console.WriteLine(siradakiKisininAdı);
//} 

string[] sira2 = { "Muhammet", "Umut" }; // new string[2] //Verdiğimiz başlangıc degeri kadar array olusturacaktır.
string[] sira3 = new string[5]
{
        "Muhammet",
        "Umut",
        "Berkay",
        "Emir",
        "İlhami",
};

//sira3[5] = "Hacer"; //Error
//string[] sira4 = new string[6];
//for (int i= 0;i<sira3.Length;i++)
//{
//    sira4[i] = sira3[i];
//}

//Array.Resize(ref sira3, 6);
//sira3[5] = "Hacer";

//string[,] cokluSira=new string[2, 2];
//cokluSira[0, 0] = "Güven";
//cokluSira[0, 1] = "Ahmet";

//Array.Sort(cokluSira);
//Array.Fill(sira3, "Null");

//bool ahmetVarMi = sira.Contains("Ahmet");
//string siraString = string.Join(", ", sira);
//Console.WriteLine(siraString);

// Koleksiyon
Console.WriteLine("--------Koleksiyonlar----------");

//List
List<string> sira4 = new List<string>();
sira4.Add("Ahmet");
sira4.Add("Hacer");
sira4.Add("Emir");
sira4.Remove("Ahmet");

//foreach (string siradakiIsim in sira4)
//{
//    Console.WriteLine(siradakiIsim);
//}

// Dictionary
// Anahtar ve Değer eşleşmesiyle bir sözlük yapısı oluşturur.
Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
Dictionary<string, string> sira5 = new();

sira5.Add(key: "Birinci Sıra", value: "Ahmet");

foreach (KeyValuePair<string, string> siradaki in sira5)
{
    Console.WriteLine($"{siradaki.Key}, {siradaki.Value}");
}

// ArrayList 
// Elaman veri tipi dinamiktir.
ArrayList sira6 = new();
sira6.Add("Ahmet");
sira6.Add(null);
sira6.Add(15);
sira6.Add(true);

// LinkedList
LinkedList<string> sira7 = new();
sira7.AddFirst("Ahmet");
//var sira7Iliski = sira7.First.Next.Previous.Value;

// HashSet
// İcindeki elemanları tamamen birbirinden farklı olmak durumunda
HashSet<string> katilimcilar = new();

katilimcilar.Add("ahmet@tobeto.com");
katilimcilar.Add("said@tobeto.com");

#endregion

#region Class
//Referans Tip
//C# Nesne Dayalı (OOP) Programlama Dili
// Class'lar Nesneler oluiturmak icin bir sablondur diyebiliriz.
//Console.WriteLine("-------Class--------");
//Student ogrenci = new(); // Nesne // Referans
//ogrenci.FirstName = "Ahmet";
//ogrenci.LastName = "Cetinkaya";//

//Console.WriteLine(ogrenci.FullName);

//Student ogrenci1 = new()
//{
//    FirstName = "Muhammet",
//    LastName = "Mutlo",
//    Yas = 25
//};
//Console.WriteLine($"ogrenci1 :{ogrenci1.FirstName}--{ogrenci1.LastName}--{ogrenci1.Yas}");

//Student ogrenci2 = ogrenci1;
//ogrenci1.LastName = "Mutlu";

//Console.WriteLine($"{ogrenci1.FirstName}--{ogrenci1.LastName}--{ogrenci1.Yas}");
//Console.WriteLine($"{ogrenci2.FirstName}--{ogrenci2.LastName}--{ogrenci2.Yas}");

#endregion

#region Deger ve Referans Veri Tipleri
//Deger Veri Tipleri
int number1  = 10; //10  //30
int number2 = 20; //10  //20
//int toplam = number1 + number2;

number2 = number1; //number2: 20->10
number1 = 30; ////number1: 10->30
Console.WriteLine(number2); //10

//Referans Veri Tipleri
string[] cities1 = //0x3271 (Hexidecimal 16'lık  sayı  sistemindeki sayı)
    new string[2] { "Konya", "Istanbul" }; //Veri HEAP'daki ayrılan yere yerleitirilir, örneğin adresi 0x3271
string[] cities2 //0x5271
    = new string[2] { "Ankara", "Izmir" }; //Veri HEAP'daki ayrılan yere yerleitirilir, örneğin adresi 0x5271

cities2 = cities1; // 0x5271 --> 0x3271

//for (int i = 0; i < cities1.Length; i++)
//    cities2[i] // 0x5271
//    = cities1[i];

cities1[0] // 0x3271
    = "Antalya";
Console.WriteLine(cities2[0]); //Antalya

const int number3 = 10; //Sabit degere sahip degisken
//number3 = 11;

// Immutable 
ImmutableArray<string> cities3 =cities1.ToImmutableArray();
//cities3[0] = "Konya";

string city1 = "Konya"; //0x4242
string city2 = "Ankara"; //0x0606

city2 = city1; //0x0606-->0x4242
Console.WriteLine(city2);  //Konya

#region Temsili Arka Plan
ImmutableArray<char> setString (ImmutableArray<char>city1Array) //0x4242
{
    ImmutableArray<char> city1ArrayToAntalya = //0x0707
        ImmutableArray.Create('A', 'n', 't', 'a', 'l', 'y', 'a');//char[7] 

    //Array.Resize(ref city1Array, 7);
    //for (int i = 0; i < city1Array.Length; i++)
    //{
    //    city1Array[i] = city1ArrayToAntalya[i];
    //}
    return city1ArrayToAntalya;
}
#endregion 

city1 = "Antalya"; //0x4242-->0x0707
city1 += "Güzeldir";//0x0707-->0x0807
Console.WriteLine(city2);

// StringBuilder
StringBuilder stringBuilder = new(); // 0x9284 // Allocation
stringBuilder.Append("**Antalya"); //0x9284
stringBuilder.Append(" Güzeldir**");  // 0x9284 

Console.WriteLine(stringBuilder.ToString()); // 0x7292 // Allocation

#endregion

#region Nesne Yönelimli Programlama (OOP)
/*Object Oriented Programming
 *Sınıflar ve Nesneler:Yazılım, gerçek dünyadaki ve iş sürecindeki nesnelerin tanımı ve
  davranışlarını içeren sınıflardır, ve sınıflarla üretilen nesnelerle oluşur.
 *
 *Kapsüllme (Encapsulation): Özellikleri, davranışları bir arada tutmak  ve bunlara dışardan erişimini kontrol edebilmemiz
 *
 *Katılım (Inheritance): Sınıflar arasında bir "parent-child" ilişkisi kurulması ve aynı zamanda is-a ilişkisi kurulması,
 *bir sınıfın özellikleri ve davranışlarını diğer sınıfa miras olarak geçebilmesidir.
 *Böylece yazılımın bazı parçaları tekrar kullanabilir.
 *
 *Çok Biçimlilik (Polymorphism) : Aynı isimdeki davranışların farklı sınıflarda farklı şekilerde davranabilmesini sağlar.
 *Bu da yazılımda esnekliği artırır.Ek olarak;Base Class'lar Child class'ların referanslarını tutabiliyorlar.
 *
 *Soyutlama (Abstract) : Karmaşık sistemleri  basitleştirmek için ortak özellikleri belirleyerek soyutlama gerçek hayatta oldduğu gibi
 *soyutlama yapılır.
*/


User user = new User(
    id:lastId++, 
    firstName:"Hacer Sema", 
    lastName:"Aktas", 
    nickName:"Hacer.Aktas", 
    email:"hacer@example.com", 
    password:"1234");
Entity user1 = new User(
    id: lastId++,
    firstName: "Hacer Sema",
    lastName: "Aktas",
    nickName: "Hacer.Aktas",
    email: "hacer@example.com",
    password: "12345");

Console.WriteLine(user.Id);
Console.WriteLine(user1.Id);
Console.WriteLine("----------------------");
int lastId = 0;
Student student= new(
        id: ++lastId,
        firstName: "Emir",
        lastName: "Karameke",
        nickName: "emir.karameke",
        email: "emir@example.com",
        password: "123456",
        phoneNumer: "123456",
        yas: 25
    );
Console.WriteLine(user.Id);

Console.WriteLine("----------------------");
Instructor instructor = new(
        id: ++lastId,
        firstName: "Ahmet",
        lastName: "Çetinkaya",
        nickName: "ahmet.cetinkaya",
        email: "ahmet@example.com",
        password: "123456",
        field: "Software"
    );
//Console.WriteLine(instructor.Password);
//entityRepository.UpdateEntity(user);
//entityRepository.UpdateEntity(student);
//entityRepository.UpdateEntity(instructor);
#endregion
