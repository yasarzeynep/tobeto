namespace ConsoleUI 
{
  class MathHelper
    { 
        //Erişim Belirteci (access modifer)
        //metotların varsayılan erişim belirteci (access modifier): private 
      
        internal int topla(int sayi1, int sayi2)  //metot
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        //int topla(int x, int y)  //Error already  exists
        //{
        //    int toplam = x + y;
        //    return toplam;
        //}


        //Method overloading 
        internal string topla(string sayi1, string sayi2) //metot ismi+ parametrelerin veri tip  sırası -->metotun imzası
        {
            int toplam = Convert.ToInt32(sayi1) + int.Parse(sayi2);
            return sayiyiStringeCevir(toplam);
        }

     private string sayiyiStringeCevir(int sayi)
        {
            return sayi.ToString();
        }
    }
}
