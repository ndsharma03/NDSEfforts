//Onject 
//way -1:
//Object literal syntex : Key value pairs
// problem: for each object we need to define multiple times.
// in js object is a collection of Key-value pairs
/*
const Circle = {
    radious: 3,
    location: {
        x: 0,
        y: 0,
    },
    draw: function () {
        console.log(" Drawing circle");
    }
}

//Circle.draw();

// way 2:
// Factory Function:

function createCircle(radius) {
    return {
        radius,
        draw: function () {
            let msg = "drawing circle of radius :" + radius;
            console.log(msg);
        }
    };
}
const circle1 = createCircle(5);
circle1.draw();
*/ //<-- open this Comment
// way 3 :
// Constructor function:
function CircleCtr(radius){
    this.radius=radius,
    this.draw=function(){
       console.log("drawing circle via 'costructor function' of radius  :" + this.radius);
    }
}

const objCircle=new CircleCtr(44);
objCircle.draw();

//************************************************************************* */
// constructor function used this keyword,while factory function not(for peorties/methods).
// conctructor function create a new empty object via new keyword and then sets proerty 
//and methods to it.
// in factory function we are returning object so we need return keyword in factory function
// while in constructor function we have to use new keyword which does this automatically 
//so no need of return keyword.
// if we will not use new keyword in case of constructor function, all methods and properties 
//will be attached to global object(window),but tools/editors enforces us to use 'new' keyword.



// const obj1={
//     name:"niranjan",
//     age:37
// };
// const obj2={
//     name:"niranjan",
//     age:37
// }
// console.log(obj1===obj2); //result =false

//************* Two objects of same type with same values are not equal. */
// function Employee(firstname,lastname,age){
//     this.firstname=firstname,
//     this.lastname=lastname,
//     this.age=age
// }
// var e1=new Employee("niranjan","sharma",27);
// var e2=new Employee("niranjan","sharma",27);
// console.log("Is e1 and e2 are equal?"+( e1==e2)); // result false??
// console.log(e1.constructor);
// console.log(e2.constructor);

// functions are objects internally java script calls Function() constructor to 
// create Function object. like below

// let abc=new Function('a,b',`let c=a+b; console.log(c);`);
// abc(4,5);
// console.log(typeof(abc));
// // 
// let a=10;
// let a1=new Number(10);
// console.log (`value of a={`+ a +`} and value of a1={`+ a1 +`}`);
// console.log(a===a1);//false
// console.log(typeof(a) +' ' +typeof(a1));//a=number - - a1=object

//=============Call by value, call by reference=========

// let num1= {value:10};//object

// function ChangeNumber(num){
//     num.value=11;
// }
// ChangeNumber(num1);
// console.log(num1.value); // will print 11 as it's a object and pass by reference so it changes actual object.
// function ChangeNumber2(num){
//     num={value:22}; //assigning a new object to num;
// }
// ChangeNumber2(num1);
// console.log(num1.value); // no change in value still it will be 11. as we have assigned new object 
//inside function so new object's scope will be indside function only.

//
// ============Properties in JS==============
// object are dynamic in javascript we can add properties at runtime.

let cir1=new CircleCtr(10);
cir1.location={x:10,y:10};
//now we have both properties with CircleCtr object.
console.log(cir1.radius);
console.log(cir1.location);
console.log(cir1["radius"]);
// delete proprty
delete cir1.location; //or delete cir1["radius"];console.log(cir1.location); 

//==========enumrating through object properties
// via for in loop
// for(let key in cir1){
//     console.log(key);// name of property :will return  properties and functions
//     console.log(cir1[key]); // value of property
//     // to filter property only
//     if(typeof cir1[key]!=='function'){
//         console.log(key +' is a property in CircleCtr');
//     }
// }
// // another method to get all keys of a object
// var keys=Object.keys(cir1);
// console.log(keys);// will retrun all properties (keys) of object passed to function

// //******** How to check weathe a property exist in an object========
// if('radius' in cir1){
//     console.log(" Yes radius is a property of cir1 object");
// }

//===========how to create private function and property:
var Database=function (tablename){

   // this.tablename=tablename;// will create public property;
   //let tablename=tablename; // error tablename is already declared.
    let createConnection=function(){ //private function
        console.log("Creating connection to database" +tablename);// this.tablename is undefined here

    }
    let executeCommand=function(){ // private function
        console.log("Executing command ..");
    }
    this.GetData=function(){
        createConnection();
        executeCommand();
        console.log("Fethcning data from  "+ tablename);//
    }
}
let db=new Database("Employee");
db.GetData();
console.log(db.tablename);//undefined as 'tablename' is local and not accessible here.
//db.createConnection();//not accessibe
//db.executeCommand();//not accessible

//==================Getter/setter========
let Emploeyee=function(fname,lname,sal){
    let firstname=fname;
    let lastname=lname;
    let salary=sal;

    //defining properties
    Object.defineProperty(this,"FirstName",{

        get: function(){
            return firstname;
        },
        set:function(val){
            firstname=val;
        }
    }
    );
    Object.defineProperty(this,"LastName",{

        get: function(){
            return lastname;
        },
        set:function(val){
            lastname=val;
        }
    }
    );
    Object.defineProperty(this,"Salary",{

        get: function(){
            return salary;
        }
    }
    );
}

const emp1=new Emploeyee("Niranjan","Sharma",200000);
emp1.FirstName="Bittu";// using setter of property
console.log(emp1.FirstName);
console.log(emp1.LastName);
console.log(emp1.Salary);

//==================