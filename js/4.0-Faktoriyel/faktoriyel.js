  
  
  const bilgiDizgisi=" Faktoriyel Değeri Burada Gösterilir";

  function faktoriyel(){
  
  
  var deger= ~~document.getElementById("input1").value;
  var faktoriyel=0;
  var degerSakla=deger;
if(deger>=0) {
  if(deger==0 || deger==1)
  faktoriyel=1;
 else if (deger==2)
 faktoriyel=2;
 
 else {
   faktoriyel=deger;
    while(deger>2)
    {
     faktoriyel=faktoriyel*(deger-1);
     deger=deger-1;
 
    }
 }

 document.getElementById("input2").value= degerSakla+ " değerin faktoriyeli "+ faktoriyel ;
}
 else
  alert("Lütfen 0 ya da pozitif bir sayı giriniz");
 

  }

  

  function temizle(){

    //alert("su anda temizlenin icerisindeyim");

    document.getElementById("input1").value="";


   document.getElementById("input2").value=bilgiDizgisi;
    // alert("input2 tarafından güncellenecek");
   sayfaYukle(2);
    
  }

  function sayfaYukle()
  {

  var kaynak= arguments[0];
  if (kaynak==1)
  alert("sayfaYukle, body.onload tarafından çağrılmıştır.");
  else if (kaynak==2)
  alert("sayfaYukle, temizle() tarafından çağrılmıştır.");
  else if (kaynak==3)
  alert("sayfaYukle, bilinmeyen bir işlev tarafından çağrılmıştır.");

  document.getElementById(sayfaYukle).innerHTML=bilgiDizgisi;
   
  }