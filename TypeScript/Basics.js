// variables in type script
//********number****** */
var varNumber;
console.log(varNumber = 333);
//console.log(varNumber="333");  // it will not compile as "333" is a string.
//********string****** */
var varString = "Niranjan";
varString = "333";
console.log(varString);
//********Boolean****** */
var varBoolean;
varBoolean = true;
console.log(varBoolean);
//********Array****** */
var varIntArray;
varIntArray = [23, 73, 53, 43];
console.log(varIntArray);
// another way to declare array..
var varNumArray;
varNumArray = [34.44, 4, 22, 56];
console.log(varNumArray);
//below line will generate error as varNumArray will take only numbers.
// varNumArray=[7483,"894",true];
// console.log(varNumArray);
var intTuple;
intTuple = ["hello", 2];
console.log(intTuple);
var strTuple = [32, "djid"];
console.log(strTuple);
// strTuple=["fist","secind"]
// console.log(strTuple);
var intTuple2 = [32, 34];
