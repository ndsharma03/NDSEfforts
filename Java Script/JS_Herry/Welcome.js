console.log("Welcome");
// let a = document;        // Open comments and see result in dev tools.
// console.log(a);

//let all = document.all;
//console.log(all);

// let dcbody=document.body;
// console.log(dcbody);

//let dcforms = document.forms;
//console.log(dcforms);

//iterating through form elements
// Array.from(all).forEach(function(e){//Array.from(all) used to convert dom elements to array to iterate
//     console.log(e);
// });
//************about links object******* */

// let a1 = document.links; // will print all links in docuemnt
// Array.from(a1).forEach(function (e) {
//     //Array.from(all) used to convert dom elements(a1) to array and then iterating over elements.
  
//     if(e.id==="lnk")// checking id of element and if it's equal then printing its attribute(href)
//         console.log(e.href);
    
//     console.log(e);
// });

// about window object
// scrollX and scrollY
console.log(window.scrollX); // will give you scroll position in X axis.
console.log(window.scrollY);// will give you scroll position in Y axis.

console.log(window.location);
console.log(window.location.href);
console.log(window.location.port);
console.log(window.location.protocol);
