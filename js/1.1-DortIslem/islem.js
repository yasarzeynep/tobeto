/* Dört İşlem Uygulama 2 */

function topla(){
   // alert("Şu anda toplam işleminin içindeyiz");
    var birirncisayi=+document.getElementById("input1").value;
    var ikincisayi=+document.getElementById("input2").value;
    var toplam;


    toplam=birirncisayi+ikincisayi;
    document.getElementById("p1").innerHTML=toplam;
}

function cikar(){
  //  alert("Şu anda cıkarma işleminin içindeyiz");
    var birirncisayi=+document.getElementById("input1").value;
    var ikincisayi=+document.getElementById("input2").value;
    var cikarma;


    cikarma=birirncisayi-ikincisayi;
    document.getElementById("p1").innerHTML=cikarma;
}

function carp(){
    //alert("Şu anda cıkarma işleminin içindeyiz");
    var birirncisayi=+document.getElementById("input1").value;
    var ikincisayi=+document.getElementById("input2").value;
    var carpim;


    carpim=birirncisayi*ikincisayi;
    document.getElementById("p1").innerHTML=carpim;
}
function bol(){
    // alert("Şu anda cıkarma işleminin içindeyiz");
    var birirncisayi=+document.getElementById("input1").value;
    var ikincisayi=+document.getElementById("input2").value;
    var bolum;


    bolum=birirncisayi/ikincisayi;
    document.getElementById("p1").innerHTML=bolum;
}
function temzile(){
    document.getElementById("input1").innerText="";
    document.getElementById("input2").innerText="";
    document.getElementById("p1").innerHTML="Sonuçlar Burada gösterilir...";
}