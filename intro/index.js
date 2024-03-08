
console.log("Hello .NET 2A");

//Type-safe degildir

var number =10;
console.log(number);
number="Hello";
console.log(number);
console.log(typeof(number));

//EcmaScript ES2016 ES2017

hesapla();

function hesapla()
{
    var x=10;
    var y=20;

    for(var i=0; i<10; i++)
    {
        console.log(i);
    }
    console.log("for dongüsünün dısından i degeri: " , i);
    console.log(x+y);
}


var number2=10;
var number2=20;
console.log(number2);

//Hosting 
number3=10;
console.log(number3);
var number3;


//ec6 => let 
let number4=60;
console.log(number4);

function hesapla2()
{
    let x=10;
    let y=20;

    for(let i=0; i<10; i++)
    {
        console.log(i);
    }
   console.log("for dongüsünün dısından hesapla2 i degeri: " , i);
    console.log(x+y);
}
hesapla2();

// let  number4=30; //cannot declare number4

const number5=50;

// Arrow function
let myFunction = () => {
    console.log("myFunction");

}
myFunction ();

let user={
    name: "Halit",
    surname: "Kalaycı"
};

console.log(user.age);
