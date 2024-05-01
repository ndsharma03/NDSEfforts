

// var person={firstName:"niranajn",lastName:'sharma',age:33};
// person.__proto__.Details=function(){
//     console.log(this.firstName+" - "+this.lastName+" - "+this.age);
    
// }
// //---------------------------------------------------------
// console.log(person.Details())
// person.address="blr";
// var p2=Object.assign({},person); // way to create new object from existing
// p2.firstName="Manoj";

// console.log(p2.Details())
// console.log(person.Details())
// var p3=person;  //assigning person to p3 and changing 'p3'
// p3.firstName="Pallavi"; // both p3 and person will be chnaged.

// console.log(p3.Details())
// console.log(person.Details())
// //----------------------------------------------------------

// function change(per){ 
//     per.firstName="Changed";
// }

// change(person); //passing person object to change function and changing firstname.
// person.Details();//persons firstname will be changed.

// //---------------------------------------------------------

// let clsEmployee=function(name,designation,salary){
//     this.name=name,
//     this.designation=designation,
//     this.salary=salary,
//     this.Details=function(){
//         console.log(this.name+":"+this.designation+":"+this.salary);
//     }
// }

// let e1=new clsEmployee('niranjana','teamlead',1500000);
// let e2=new clsEmployee('pallavi','housewife','5000');
// console.log(e1.Details());
// console.log(e2.Details());

// //inheritance using prototype
// var clsManager=function(noOfSubOrdinates){
//     this.noOfSubOrdinates=noOfSubOrdinates;
// }

// clsManager.prototype=clsManager.prototype;

//--------------------------------------------------------------------

//prototypal inheritance:

// let animal={
// name:"animal",

// speak:function(){
//     return this.name +":" +'bho bho';
// }

// }
//------------Prototype inheritance---------------
// let dog={
//     name:"dog"
// }
// console.log(dog.name);
// dog.__proto__=animal;
// dog.__proto__.Test=function(){
//     console.log(this.name+" "+this.speak());
// }
// animal.Test();


// let newAnimal={
//     name:"gaya",
//     surname:"MAta"
// }
// newAnimal.__proto__=animal;
// console.log(newAnimal.speak());
// console.log(newAnimal)
//-----------------------------------
// var name="GlobalValue"
// var Obj={
//     name:"localValue",
//     print:function(){
//         console.log(this.name);
//     },
//     print2:()=>{
//         console.log(this.name);// this with Arrow function refers Global object;
//     }
// }
// Obj.print();
// Obj.print2();

// for(let k in Obj){
//     console.log("--------------");
// }

//--------------For in--------for of loop-----------

var basePerson={hasAncestor:true}
var person = {fname:"John", lname:"Doe", age:25};
person.__proto__=basePerson;
var text = "";
var x;
for (x in person) {
  text += person[x] + " ";
}
console.log(text)
console.log(person.hasAncestor);

let arr=[2,3,4,5,6];
for (x of arr) { //for of works with iterable objects.
    text += x + " ";
  }
  console.log(text)