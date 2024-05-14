/* Toplama Ornek 1 */

function topla(){
    alert("Şu anda toplam işleminin içindeyiz");
var birirncisayi=+document.getElementById("input1").value;
    var ikincisayi=+document.getElementById("input2").value;
    var toplam;


    toplam=birirncisayi+ikincisayi;
    document.getElementById("p1").innerHTML=toplam;
}