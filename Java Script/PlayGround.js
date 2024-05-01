var arr=[45,7,8,4,12,1,177,7,8];
// arr.unshift(34);
//  console.log(arr);
// arr.shift(2);
// console.log(arr);

//delete duplicate
// var dist=new Set(arr);
// console.log(dist);
// let kk=Array.from(dist);
// kk.forEach((v,i)=>{
//     console.log(`index=${i}, value=${v}`);
// })

var max=0;
for(let i=0;i<arr.length;i++){
    if(arr[i]>max){
        max=arr[i];
    }

}
//var arr=['amit','bittu','zee','dargling','guru','kumar']
console.log(arr.sort())
console.log("maximum of arr is ="+max);

//===========sorting

//4,6,9,2,3,7,1
 
for(let i=0;i<arr.length;i++){
    for(let j=i+1;j<(arr.length);j++){
let temp=0;
if(arr[i]>arr[j]){
    temp=arr[i];
    arr[i]=arr[j];
    arr[j]=temp;
}
}
}

console.log(arr);
//================================

arr.forEach((v,i)=>{console.log( i, "==", v)});
arr.map((v,i)=>{console.log( i, "==", v)})