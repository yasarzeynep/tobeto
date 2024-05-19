  

 const genel1="genel değismez";
 var k=1000, l=2000;
function sayfaYukle()
  {

    var tanimli=123;
  
   console.log(tanimli);


   try {
   k="Atama olur";
   console.log("atama basarılı.... "+k );
   var hata= new Error ("deneme amacıyla fırlatılmıs hata.....");
   hata.name="kullanıcı tanımlı hata";
   hata.message="bu hatayı ele alacagızzzz";
    throw hata;


   }
   catch(hata){
    console.log( "sayfa yukle akısıi, hatalı durumdan ötğrğ  durdı, hata->" + hata.name + " --- " + hata.message);
   }

  finally{
    console.log("her durumda calıstırılacak kod kesimi ");
  }
   console.log("sayfayukle() isletimi buradan devam ediyor ");

   console.log( "genel1--"  + genel1);
   console.log("k + \" \" +l --->"+ k  + " " + l );
   sayfaYukleAltIsler(1234, "ikinci parametre");

  }

  function sayfaYukleAltIsler(a, b)
  {
   
 console.log("js kodumuz sayfaYukleAltIsler() etkinlik alanında calısıyor");
 console.log("a + \" \" +b --->"+ a  + " " + b );
 console.log("a[]+ ----> "  + a[0] );

 try{
  console.log("a[0][0]+ ----> "  + a[0][0] );
 }
 catch{
  console.log(" sayfaYukleAltIsler() akısı  hatalıu durumdan oturu durdu--->"+ hata.message);
 }

 finally{
  console.log("her durumda calıstırılacak kod kesimi ");
 }

 try {
  document.getElementById("p1").innerHTML= "<span> style= \" border:2px gray solid\" eval() denemesi" +eval("4---18")+"</span>";
 }
 catch (hata){

 }
 finally{
  
 }

  }
  
  