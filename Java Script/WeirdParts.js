/*
//what will be output of below code
console.log("case 1:")
console.log(1+'2');//Ans : 12 as js converts int to string and contacatenates both

//Question 2:
console.log("case 2:")
console.log(3>2>1); //Ans : true

//Question 3: 
console.log("case 3:");
console.log(3<2<1);
//Expected 'false' but will get 'true' as ('false'<1) ->(0<1) so true.

console.log("case 4:")
console.log('null==0 '+(null==0));// expected true but this expression will give false.

console.log("case 5: ")
console.log(""==0);
console.log(""==false);
//=========================/
console.log("Case 6:")
console.log(Number(true)); //1
console.log(Number(false)); //0
console.log(Number(undefined));// NaN
console.log(Number(null));//0
console.log(Boolean(undefined));// false
console.log(Boolean(null));//false

//=========================/


function Abc(name){
    console.log("Hello " +name);
}

Abc();
//Result: 'Hello undefined ' as name's value is undefined. 

Abc("Nds", 4,"garbage vale"); 
//Result : "Hello Nds" as function call will ignore other values.



//======Gocha with '||' operator==========

var name;
function Greet(name){
name=name || 'default value for name param';
console.log(name);
}
Greet(name);//name is undefined ; Result :'default...'
name=null;
Greet(name); // name=null Result :'default...'
name="";
Greet(name); //name="" result:'default value for ..'
name='abc';
Greet(name);//name='abc' result:abc;
name=0;
Greet(name);// default value for ...' as 0=fasle and 'default...'=true so false||true=>true
console.log(Boolean('default value for name param'));

*/
//object 
var Person={};
Person.FirstName="niranjan";
Person.LastName="Sharma";
 console.log(Person);
// console.log(Person.FirstName);
// console.log(Person.LastName);
// console.log(Person["FirstName"]);
// console.log(Person["LastName"]);
// console.log(Person.__proto__.toString());

