// [this] alone repesent global object i.e. window
var variable1 = this;
console.log(variable1);

//*** 'this' within function ********************
function abc() {
    console.log(this); //inside of function 'this' also represent globalObject(window)
}
abc();
var func1 = function () {
    return this;
}
console.log(func1());// again you will get gloabl object;

// ***************** In an event 'this' refers HTML element******************
/* here this refers button object
<button onclick="this.style.display='none'">
  Click to Remove Me!
</button>
*/

//***  'this' within Object method ***************
var person = {
    firstName: "Niranjan",
    lastName: "Sharma",
    getFullName: function () {
        return this.firstName + " " + this.lastName; // here 'this'=person object
    }
};
console.log(person.getFullName());//result:  "Niranjan Sharma"

var func2=function(val1, val2) {

    console.log(val1 + " " + val2);
   return function() {
        console.log("value of val1 {"+val1+"} and val2 {"+val2+"} inside inner function");
        console.log("inside inner function [this] represent global object"+ this);
        console.log("value of val1 using [this] {"+this.val1+"} and val2 {"+this.val2+"} ");
        // using 'this', val1 and val2 is undefined.
       // Inside a function 'this' represents global object.
       console.log(this);
    }
};
var func3=func2(4,5);
func3();

