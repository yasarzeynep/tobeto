  function karsilastir(){
  alert("su anda karsılastırın icerisindeyim");
  var geciciDizgi ="";
  var birinciSayi, ikinciSayi;

 birinciSayi = + document.getElementById("input1").value;

 ikinciSayi= + document.getElementById("input2").value;

 if(birinciSayi==ikinciSayi)
 geciciDizgi=birinciSayi + "=" + ikinciSayi ;
 else if(birinciSayi>ikinciSayi)
  geciciDizgi=birinciSayi + ">" + ikinciSayi ;
else
geciciDizgi=ikinciSayi + ">" + birinciSayi ;
 
document.getElementById("p1").innerHTML= geciciDizgi;
  }


  
  function temizle(){
    alert("su anda temizlenin icerisindeyim");

    document.getElementById("input1").value="";
    document.getElementById("input2").value="";
    document.getElementById("p1").innerHTML=" Karşılaştırma Sonucu Burada Gösterilir";
  }