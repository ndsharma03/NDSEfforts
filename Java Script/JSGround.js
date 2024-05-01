console.log(1+true);// result : 2 -> true converted to int 1 and then added to 1.
console.log(1+"2"); // result : 12
console.log(1+false);// result : 1
console.log(1+"hello");//result : 1hello
console.log(true+"false"); // result: truefasle
console.log(3-4); //result :-1
console.log(true); // result :true.


console.log("****************************************************************");

// function TestArgs(first,second){

//     console.log("type of first param "+typeof(first) +" value = "+first);
//     console.log("type of second param "+typeof(second) +" value = "+second);
   
// // returning second args if it's a function.
//   if(typeof(second)=="function"){
//     return  second;

//   }
// }

// // We can pass anything as a function arguments
// // Testing function with diferent args:
// console.log(TestArgs);
// TestArgs("Hello","World");//string-string;
// TestArgs("Hello",123);//string -int
// TestArgs("Hello", true);
// TestArgs(false,true);
// TestArgs(123,456);
// TestArgs();
// TestArgs(null,"Only Second Args");
// TestArgs("Only First Args");
// TestArgs({val1:'value of first property',val2:'val of second property'},{val:12312});

// // passing function as a argument(callback)
// var test=TestArgs("first value",function (){ console.log ('callback function')});
// console.log(test);
// test();

var newFunc=function(){
    return function(){
        console.log("returing function from function");
    }
}
console.log(newFunc());//newFunc().toString();
console.log(newFunc);
newFunc()();//calling function will return function which will be called by second();
//=============================
console.log("******************** Object equilaty **********************");

var x1=new Object(10);
var x2=new Object(10);
result=x1==x2;
console.log(result);

result=x1===x2;
console.log(result);

console.log("Value of x1= "+x1.toString());
console.log("Value of x2= "+x2.toString());

result=x1.toString()==x2.toString();
console.log("Value of x1==x2 " + result);
