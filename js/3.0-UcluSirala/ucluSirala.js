  
  
  const bilgiSatiri=" Üçlü Sıralama Burada Gösterilir";

  function ucluSirala(){
  alert("su anda sıralamanın icerisindeyim");
  
  var birinciSayi, ikinciSayi, ucuncuSayi;
  var buyuk, kucuk, orta;


 birinciSayi = + document.getElementById("input1").value;
 ikinciSayi= + document.getElementById("input2").value;
 ucuncuSayi= + document.getElementById("input3").value;


  if(birinciSayi>ikinciSayi) {
    buyuk=birinciSayi ;
    kucuk= ikinciSayi ;
  }
 
else
{
  buyuk=ikinciSayi;
  kucuk=birinciSayi ;
}

if(ucuncuSayi>buyuk) {
  orta=buyuk;
  buyuk=ucuncuSayi;
}

else{
  if(ucuncuSayi>kucuk) 
    orta=ucuncuSayi;
  else{
    orta=kucuk;
    kucuk=ucuncuSayi;
  }
   
}


document.getElementById("p1").innerHTML= buyuk + "," + orta + "," + kucuk ;
  }

  function sayfaYukle()
  {
    document.getElementById(sayfaYukle).innerHTML=bilgiSatiri;
    {

    }
  }

  function temizle(){

    // var bilgESatiri = "Bilgelik......";
    alert("su anda temizlenin icerisindeyim");

    document.getElementById("input1").value="";
    document.getElementById("input2").value="";
    document.getElementById("input3").value="";
    document.getElementById("p1").innerHTML=bilgiSatiri;

    // bilgESatiri = bilgESatiri + "Önemlidir......";
  }