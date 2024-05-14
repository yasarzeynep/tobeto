/* Dört İşlem Uygulama 2 */


const toplaSabit=1;
const cikarSabit=2;
const carpSabit=3;
const bolSabit=4;

function islem(islemKodu){
    var birirncisayi=+document.getElementById("input1").value;
    var ikincisayi=+document.getElementById("input2").value;
  

  switch(islemKodu)
{
   case toplaSabit:
   document.getElementById("p1").innerHTML=birirncisayi+ikincisayi;
   break;

   case cikarSabit:
   document.getElementById("p1").innerHTML=birirncisayi-ikincisayi;
   break;

   case carpSabit:
   document.getElementById("p1").innerHTML=birirncisayi*ikincisayi;
   break;

   case bolSabit:
    document.getElementById("p1").innerHTML=birirncisayi/ikincisayi;
   break;

   default:
    alert("herhangi bir işlem tercihinde bulunulmadı");
     
}}

function temzile(){
    document.getElementById("input1").innerText="";
    document.getElementById("input2").innerText="";
    document.getElementById("p1").innerHTML="Sonuçlar Burada gösterilir...";
}