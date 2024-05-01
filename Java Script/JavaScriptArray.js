var abc=[];
    abc.push(23);
    abc.push(24);
    abc.push(25);
    abc.push(26);
    abc.push(27);

    //abc.forEach(x=>{console.log(x)});
    // console.log(abc.indexOf(24));
    // console.log(abc.map(x=>x>24));
    // console.log(abc);

//**(******************* SetTimeOut************* */

var k=setTimeout(()=>{
console.log(" executing after some time")
},1500);
clearTimeout();
for(i=0;i<100;i++){
console.log("executing other task");
console.log("*********************");
}

var a=90;
{
    var a=80;
}
var a='pagal'
console.log(a);