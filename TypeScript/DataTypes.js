/*
Number
Boolean
String
Array
Tuple
Enum
Any
Void
Union types
Type alias

*/
var numTest;
var strTest;
var boolTest = true;
//let variablename:datatype=value;
// let arr:number[];
// arr=[78,89,90];
// console.log(arr);
var arr = [23, 23, 44];
console.log(arr);
// 
var Colors;
(function (Colors) {
    Colors[Colors["red"] = 10] = "red";
    Colors[Colors["green"] = 11] = "green";
    Colors[Colors["blue"] = 12] = "blue";
})(Colors || (Colors = {}));
;
var _color = Colors.red;
console.log(_color);
//Tuple:
var _tpl;
//_tpl=[23,56,'hello'];
console.log(_tpl);
var anyTest;
anyTest = "niranjan";
console.log(typeof anyTest);
anyTest = 90;
console.log(typeof anyTest);
anyTest = true;
console.log(typeof anyTest);
var unTest; //union type;
unTest = 89;
unTest = 'dgdgd';
console.log(unTest);
var unTest2;
unTest2 = 89;
unTest2 = 'dgdgd';
unTest2 = true;
console.log(unTest2);
