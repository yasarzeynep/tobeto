  
  
  const bilgiSatiri=" Fibonacci Sayıları Burada Gösterilir";

  function fibonacci(){
  var sayiAdedi= ~~document.getElementById("input1").value;
  var ikiOnce, birOnce, Fibonacci;
  var geciciDizgi="";
  var donguDenetim;

  if(sayiAdedi < 3)
  alert("Lütfen en az 3 değer girirniz. İlk İki Fibonnaccci sayısı 1 ve 1 dir.")
  else 
  {
    geciciDizgi="ilk " + sayiAdedi+ " adet Fibonacci sayısı :  1, 1 ";
    ikiOnce=1;
    birOnce=1;

    for (donguDenetim=0; donguDenetim<sayiAdedi-2; donguDenetim++)
    {
      Fibonacci=birOnce+ikiOnce;
      ikiOnce=birOnce;
      birOnce=Fibonacci;
      geciciDizgi=geciciDizgi + " , " + Fibonacci;

    }

    document.getElementById("p1").innerHTML=geciciDizgi;
  }
 

  }

  

  function sayfaYukle()
  {
  document.getElementById("p1").innerHTML=bilgiSatiri;
  document.getElementById("button2").disabled=true;
   
  }

  function veriGirisi()
  {
    if(document.getElementById("button2").disabled)
  
      //alert("button2 = temizle acılıyor");
      document.getElementById("button2").disabled=false;

    
    
  }

  function temizle(){

    //alert("su anda temizlenin icerisindeyim");

    document.getElementById("input1").value="";
    document.getElementById("p1").innerHTML=bilgiSatiri;
   document.getElementById("button2").disabled=true;
  
  
    
  }
