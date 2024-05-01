

//array destructuring 

let arr = [90, 300, 930, 200];
[j, k] = arr;
console.log(j + " " + k);

// ... (rest operator)

[l, m, ...p] = arr;
console.log(l + " " + m);
console.log(typeof p + " " + p);

//************ object destructring ************:
//Example 1:
let { a, b } = { a: 10, b: 30, c: 90 };
console.log(a + " " + b);

//Exaple 2: object function destrucring
let obj = {
    write: function () {
        console.log("hello");
    }
}
let { write } = obj; 
write();

//Destructuring with function argument
// Normally we work with object like below
let obj2 = {
    firstname: "nirnajan"
}

function WriteToConsole(val) {
    console.log(val);
}
WriteToConsole(obj2.firstname);//rsult:niranjan


//Destructuring : instead of passing object we can extract param directly
function WriteToConsole2({ firstname }) {
    console.log(firstname);
}
WriteToConsole2(obj2);


//Some complex (nested object)destructuring examples
let customer = {

    firstName: "abc",
    lastName: "bcd",
    Order: [{
        orderDate: '12/12/2020',
        orderId: 1
    }],

}

// To destructing from array within object
let { firstName, Order: [{ orderId }] } = customer;
console.log(firstName + "****" + orderId);


//another example:
var user = {
    id: 42,
    displayName: 'jdoe',
    fullName: {
        firstName: 'John',
        lastName: 'Doe'
    }
};
let { displayName, fullName: { firstName: name } } = user;

//here firstName:name means renaming 'firstName to name' 
// i.e displayName=user.dispalyName
// name=fullName.firstName
console.log(displayName, name);

let {firstName:name1,lastName:surname}={firstName:"Niranjan",lastName:"Sharma"};
console.log(name1,surname);

//
function abc(){
    var name="xyx";
    if(true){
        var name="zzz";
        console.log(name);         
    }
    console.log(name); // zzz; as new name varible hides old name.
}

abc();