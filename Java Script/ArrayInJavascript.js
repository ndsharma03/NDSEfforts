// Defining array
//Way 1:
/*
var arr1=new Array();
arr1[0]="Niranjan";
arr1[1]="Sharma";
arr1[3]="Bker"; // we can add item at any index.previous item will be empty item(undefined).
arr1[19]="manawar";
console.log(arr1);
console.log(arr1.length);
console.log(arr1[10]);//it will be 'undefined' as we have not assigned any item at index 10.
*/
// way 2:
//------
// var arr2=["first", 1, true]; //initalize
// arr2[3]="new item added";//adding new item.

// console.log(arr2);
// console.log(arr2.length);

var arr3=new Array(3);// 3 places will be undefined(empty) if we want to use them need to access by index.like:
arr3[0]="nds"; //now arr3[1], and arr3[2] would be 'undefined'.
arr3.push(1);
arr3.push(2);
arr3.push(3);
arr3.push(4);
arr3.push(5);
console.log(arr3);
console.log(arr3.length);//length will be 8.
for(let i=0;i<arr3.length;i++){
    console.log(arr3[i]);
    arr3.pop();
}

console.log(arr3.length);

