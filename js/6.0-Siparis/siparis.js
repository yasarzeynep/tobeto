  
  
  const bilgiIletisi=" Siparişiniz Burada Gösteriliyor";
  const tesekkurIfadesi=" Tesekkür ederiz";
  const sabitSiparisAdedi=10;
  const adetSabit="ADET";
  const onSabit="ON";


  function sayfaYukle()
  {
  document.getElementById("p1").innerHTML=bilgiIletisi;
  }

function adetSiparis(){
  var urun = document.getElementById("input1").value;
  var siparisAdedi ;
  var geciciDizgi=tesekkurIfadesi;
  var donguDenetim;

  switch (arguments [0])
  {
    case adetSabit:
      siparisAdedi = ~~document.getElementById("input2").value;
      break;
      case onSabit:
        siparisAdedi = sabitSiparisAdedi;
        break;
        default:
          alert("sipariş yapılmadı")

  }
  /* if(arguments[0]== adetSabit)
  siparisAdedi = ~~document.getElementById("input2").value;
  else if (arguments[0]== onSabit)
  siparisAdedi = sabitSiparisAdedi; */
  if(siparisAdedi < 1)
  siparisAdedi=1;

  for (donguDenetim=0; donguDenetim<siparisAdedi; donguDenetim++)
  geciciDizgi+=" "+ urun;

  document.getElementById("p1").innerHTML=geciciDizgi;
}

/* function onSiparis(){
  const siparisAdedi=10;
  var urun = document.getElementById("input1").value;
  var donguDenetim;
  var geciciDizgi=tesekkurIfadesi;

  for (donguDenetim=0; donguDenetim<siparisAdedi; donguDenetim++)
  geciciDizgi+=" "+ urun;
  document.getElementById("p1").innerHTML=geciciDizgi;
} */

  function temizle(){
    //alert("su anda temizlenin icerisindeyim");
 //debugger; // breakpoint gibi oluyor.buraya geldiğinde duruyor. F12 incele dediğinde temzileye bastoğında aktifleşir.
    document.getElementById("input1").value="";
    document.getElementById("input2").value="";
    document.getElementById("p1").innerHTML=bilgiIletisi;
   
  
  }
