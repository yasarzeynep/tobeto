  

  // const genel1="Geneldeki Sabit degisken";
  // const genel2=200;
  var k= 100, l="\"Genel\"de tanımlanmıs degisken";

function sayfaYukle()
  {
 // const genel1=999.999;
// const genel2="Yereldeki Sabit degisken";
console.log("js kodumuz sayfaYukle() etkinlik alanında calısıyor");
// var  l="\"Yerel\"de tanımlanmıs k degisken";
//var  k="\"Yerel\"de tanımlanmıs l degisken";

{
  for(let k=0; k<5; k++)
  for(let l=0; l<5000; l++)
{
  if(l>=3)
  break;
  console.log("k + \" \" +l --->"+ k  + " " + l );
}

  console.log("k + \" \" +l --->"+ k  + " " + l );
  console.log("ic ice dongu sonlandırıldı");
}


 console.log("k + \" \" +l --->"+ k  + " " + l );
 k++;
 l="Genel degiskenin degeri degisir mi?";
 console.log("k + \" \" +l --->"+ k  + " " + l );
sayfaYukleAltIsler();
  }
  
  function sayfaYukleAltIsler()
  {
    k++;
 console.log("js kodumuz sayfaYukleAltIsler() etkinlik alanında calısıyor");
 console.log("k + \" \" +l --->"+ k  + " " + l );


  }