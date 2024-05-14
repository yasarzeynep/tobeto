  
  
  const bilgiSatiri=" Fibonacci Sayıları Burada Gösterilir";
function fibonacci(n){
  console.log("deneme"+ n);
  switch(n){

    case 1: case 2:
      return 1;
      default:
        return (fibonacci(n-1)+ fibonacci(n-2));

  }
}


  function fibonacciOzyineli(){
  var sayiAdedi= ~~document.getElementById("input1").value;
  var geciciDizgi="";
  var kacinciFibo;

  if(sayiAdedi < 3)
  alert("Lütfen en az 3 değer girirniz. İlk İki Fibonnaccci sayısı 1 ve 1 dir.")
  else 
  {
    geciciDizgi="ilk " + sayiAdedi+ " adet Fibonacci sayısı :  1, 1 ";

    for (kacinciFibo=3; kacinciFibo<=sayiAdedi; kacinciFibo++)
    
      //geciciDizgi=geciciDizgi + " , " + fibonacci(kacinciFibo);
      geciciDizgi += " , " + fibonacci(kacinciFibo);
    
    document.getElementById("p1").innerHTML=geciciDizgi;
  }}

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
 //debugger; // breakpoint gibi oluyor.buraya geldiğinde duruyor. F12 incele dediğinde temzileye bastoğında aktifleşir.
    document.getElementById("input1").value="";
    document.getElementById("p1").innerHTML=bilgiSatiri;
   document.getElementById("button2").disabled=true;
  
  }
