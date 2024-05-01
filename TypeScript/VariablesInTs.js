/*
Number
string
boolean
any
void
null
undefined
array
tuple
enum
*/
var num1;
num1 = 45;
console.log(num1);
var str1 = 'niranjan';
var boolTest;
boolTest = true;
var sum;
//sum=num1+parseInt(str1);
console.log(sum);
var arr = ['e', 'er', 43, true];
console.log(arr);
var arr1 = [32, 3, 43];
console.log(arr1);
for (var _i = 0, arr1_1 = arr1; _i < arr1_1.length; _i++) {
    var a = arr1_1[_i];
    console.log(typeof a);
    console.log(a);
}
//let color:enum=[red,green,blud];
console.log('end');
var colors;
(function (colors) {
    colors[colors["red"] = 5] = "red";
    colors[colors["green"] = 6] = "green";
    colors[colors["blue"] = 7] = "blue";
})(colors || (colors = {}));
;
var _color = colors.blue;
console.log(_color);
var num3;
num3 = 32;
console.log(num3);
num3 = 'newValue';
console.log(num3);
num3 = null;
console.log(num3);
var str = null;
var numArr = [43, 43, 55, 5];
var anyVar = 'string value';
console.log(anyVar);
anyVar = 488;
console.log(anyVar);
anyVar = true;
console.log(anyVar);
var nulvar = null;
num3 = nulvar;
console.log(num3);
