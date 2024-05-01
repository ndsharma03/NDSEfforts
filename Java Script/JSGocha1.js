
// Arithmetic Operations 

console.log(14 + "" );// "14"
console.log("43"+2);//"432"
console.log("43"+"2") //"432"
console.log("43"+true)//"43true"
console.log(1+true);//2
//******* Gocha with Minus' ********** */
console.log("43"-2);//41  /
console.log("43"-"2");//41
console.log("43"-true);//42
console.log(1-true);//0
//*********************** */
var arr=["a","b"] +["c","d"];
console.log(arr); //result: a,bc,d
arr=[3,4]-[1,2]
console.log(arr);//NaN
//*********************** */
/**When you use the || operator, 
 * if the first value casts to true you will get that value returned. 
 * Otherwise, you will always get the second one. In the case of && you will always get 
 * the second value if they are both coerced to true. 
 * If the first one casts to false then you will get it’s value returned. */

const a = 100
const b = "test"
const c = null
console.log(a || b) // 100 // '||'  laways returns first value,if it's true 
console.log(a && b) // "test" // && always returns second value
console.log(a && c) // null
console.log(b && c) // null
console.log(Boolean(null),Boolean(undefined) ,Boolean(100) ,Boolean("hello"));
// result: false,false,true,true

console.log("********************************************");

//what will be output of below code
console.log("case 1:")
console.log(1+'2');//Ans : 12 as js converts int to string and contacatenates both

//Question 2:
console.log("case 2:")
console.log(3>2>1); //Ans : false

//Question 3: 
console.log("case 3:");
console.log(3<2<1);
//Expected 'false' but will get 'true' as ('false'<1) ->(0<1) so true.

console.log("case 4:")
console.log('null==0 '+(null==0));// expected true but this expression will give false.

console.log("case 5: ")
console.log(""==0);//true
console.log(""==false);//true
//=========================/
console.log("Case 6:")
console.log(Number(true)); //1
console.log(Number(false)); //0
console.log(Number(undefined));// NaN
console.log(Number(null));//0
console.log(Number(""));
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

var name1;
function Greet(k){
k=k || 'default value for name param';
console.log(k);
}
// console.log(name1);
// Greet(name1);//undf 0
var tttsdnj=null;
Greet(tttsdnj); // null null
// name1="";
// Greet("empty "+ name1); //empty
// name1='ttt';
// Greet(name1);//name='abc' result:abc;
// name1=0;
// Greet(name1);// 0
console.log(Boolean('str to bool'));


//object 
var Person={};
Person.FirstName="niranjan";
Person.LastName="Sharma";
console.log(Person);
console.log(Person.FirstName);
console.log(Person.LastName);
console.log(Person["FirstName"]);
console.log(Person["LastName"]);
console.log(Person.__proto__.toString());

//Function Gocha
function abc(){
    var name="xyx";
    if(true){
        var name="zzz"; // this name will hide above declared name
        console.log(name);         
    }
    console.log(name); // zzz; as new name varible hides old name.
}
abc();