  
  
  const bilgiIletisi=" Siparişiniz Burada Gösteriliyor";
  const tesekkurIfadesi=" Tesekkür ederiz";
  const sabitSiparisAdedi=10;
  const adetSabit="ADET";
  const onSabit="ON";
  const meyve_1="elma";
  const meyve_2="armut";
  const sebze_1="patates";
  const sebze_2="domates";

  function sayfaYukle()
  {
  document.getElementById("p1").innerHTML=bilgiIletisi;
  }

function adetSiparis(){
  var urun = document.getElementById("input1").value;
  var siparisAdedi ;
  var geciciDizgi=tesekkurIfadesi;
  var donguDenetim;
  var adetSipariseBasildi= false;

  switch (arguments [0])
  {
    case adetSabit:
      siparisAdedi = ~~document.getElementById("input2").value;
      var adetSipariseBasildi= true;
      break;
      case onSabit:
        siparisAdedi = sabitSiparisAdedi;
        break;
        default:
          alert("sipariş yapılmadı")
  }

  if(adetSipariseBasildi)
  switch(urun){

    case meyve_1: case meyve_2:
      alert("Meyve Stoklarımız yeterlidir, teşekkür ederiz..");
       break;
       case sebze_1:  case sebze_2:
        alert("Sebze Stoklarımız yeterlidir, teşekkür ederiz..");
       break;
    default:
      if(siparisAdedi>99){
        alert("Stoklarımızda"+siparisAdedi+"adet"+urun+"bulunmamaktadır; üzgünüz..");
        siparisOnayla=false;
        geciciDizgi="Siparişiniz onaylanmadı, <br> üzgünüz; teşekkür ederiz";
      }
      
      else
      alert("Stoklarımızda"+siparisAdedi+"adet"+urun+"mevcuttur; teşekkür ederiz..");
  }
if(siparisOnayla){
  if(siparisAdedi < 1)
  siparisAdedi=1;
  for (donguDenetim=0; donguDenetim<siparisAdedi; donguDenetim++)
  geciciDizgi+=" "+ urun;
}

  document.getElementById("p1").innerHTML=geciciDizgi;
}

  function temizle(){
    //alert("su anda temizlenin icerisindeyim");
 //debugger; // breakpoint gibi oluyor.buraya geldiğinde duruyor. F12 incele dediğinde temzileye bastoğında aktifleşir.
    document.getElementById("input1").value="";
    document.getElementById("input2").value="";
    document.getElementById("p1").innerHTML=bilgiIletisi;
   
  
  }
