//variables
var num;
var bul;
var str;
//-- Initialization
num = 123;
bul = true;
str = "niranjan";
console.log(num + ' ' + bul + ' ' + str);
//* if you will try to assign any other value than declared data type, you will get error.
// num="123";//error
// bul="true"//error
// str=234;//error
//**************************************/
// ===Array=====
var numArray; // declare;
numArray = []; //initialising numArray, it's necessary without init push will throw error.
numArray.push(33); // will not be able to push, if numArray is not initialize.
numArray[1] = 848;
numArray[2] = 33;
//numArray[3]="ddk";// will throw an error as it's number array
console.log(numArray);
//== tuple==
// it's similar to array but you can have multiple datatypes with fixed position
var myTuple;
//initialization
myTuple = ["niranjan", 123];
//CASE 1: if we will try to change order of datatype , we will get error, like:
//myTuple=[23,"3432"];//error
//CASE 2: below code will not work as I have given 3 values while myTuple will accept only 2 
//myTuple=['niranjan',123,'str 3rd value'];//Error
//but we can use push to insert more value which can be anytype from type used in Tuple definition.
myTuple.push(33);
myTuple.push('3rd value with the help of push');
//myTuple.push(false);//will not acceptible as bool is not in the definition of Tuple.
console.log('MyTuple : ' + myTuple);
// CASE 3: we can create tuple with multiple data types.
var anotherTuple;
//* value @ particular position should be match with tuple definition(otherwise u will getError)
anotherTuple = [123, 'strvalue', true, 'anotherStrVal', 323];
console.log(anotherTuple);
//CASE 4: tuple with same datatype
var sameDTTuple;
sameDTTuple = [101, 202, 303, 404]; // here we will be able to give only 4 values
// * but we can add more values via push
sameDTTuple.push(999);
console.log(sameDTTuple);
console.log(sameDTTuple.pop());
console.log(sameDTTuple.pop());
console.log(sameDTTuple.pop());
console.log(sameDTTuple);
//Tuple definition is same like method parameter in c#
//we need to put exact matched datatype while initialising Tuple
//after initialisation we can add any value (whose datatype is part of Tuple) with the help of push.

