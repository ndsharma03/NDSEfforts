/*
// Javascript moves variables and functions on the top of scope if it declared via 'var'.

console.log(a); //error : a is not defined

var name;        // ex 2
console.log(name);
// but in below case: k would be 'undefined'
console.log(k);
var k="hello";
// becasue above code will be converted like :
var k;
console.log(k);
k="hello"; 

//**************hoisting with functions************* */
func1();
function func1(){
    console.log("from func1");
}

//but function expressions are not hoisted..

// func2(); //Error: func2 is not a function
// var func2=function(){
//     console.log("from func2");
// };
//so in case of function expression definition should be available before use like
var func3=function(){
    console.log("from func3");
};
func3(); 

// ************** Hoisting with Let******


a=10;
console.log("a="+a)



console.log(b); // veriable declare with 'let' are not hoisted.
let b=10;