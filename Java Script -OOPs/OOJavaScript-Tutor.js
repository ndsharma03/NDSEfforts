class User{
// let score=0; we can not defined variable at class scope it's possible only via constructor.
    constructor(name,email){
        console.log('User constructor called!!');
        this.email=email,
        this.name=name,
        this.score=0
    }
    logIn(){
        console.log(this.name, 'has been logged-In !!!'); //class variable are accessible only via 'this'.
        // return this;          // if we are returning this(object if class) then we will be able to call another method
                                // of this class after this method like logIn().logOut(). it  is method chaining.
                               
    }
    logOut(){

        console.log(this.name, 'has been logged-Out !!!');
        //return this;
    }
    getScore(){
        this.score++;
        console.log(' Score of ',this.name,'is :',this.score);

    }
}

var user1=new User('Niranjan','nd@y.com');
user1.getScore();
user1.getScore();
var user2=new User('Pranamya','pp@ya.com');
user2.getScore();

console.log(" Finished --> Basic of class/method creation");
console.log('*********** Javascript Inheritance************');

//Inheritance 

var userArr=[user1,user2];
class Admin extends User{
    // User constructor will always be available here.
    delete(user){
       var tempUser= userArr.filter(u=>{
            u.email==user.email
        });
        userArr.pop(tempUser);
    }

}
let admin=new Admin('niranjan dev','ab@y.com');
admin.delete(user1); 
console.log(userArr);

//=========Java script prototype==============
//alternate way to create class in JS

function Employee(name,salary,online){
    this.name=name;
    this.salary=salary;
    this.online=false;
/*
    this.logIn=function(){
        console.log(this.name,'has been logged in successfully!!');
    }
    this.LogOut=()=>{  //another way to declare function
        console.log(this.name,'has been logged out successfully!!');
    }
    */
}

// with the help of prototype we can attach function later, instead of giving definition inside of function.
// like :

Employee.prototype.logIn=function(){
    
    console.log(' login function attached thr prototype and accessed emp name=',this.name);
    
}
Employee.prototype.LogOut=function(){
    
    console.log(' log out : Prototype : accessing salary ',this.salary);
    
 }


var e1=new Employee('nds',3000,true);
var e2=new Employee('ps',3400,false);
console.log(e1);
console.log(e2);
e1.logIn();
e2.logIn();
e1.LogOut();
e2.LogOut();
console.log('******************************************');
// inheritance via prototype
function SuperAdmin(...args)// creating SuperAdmin class .
//function SuperAdmin(name,salary,online) //another way 
{
    console.log('nn',args);
     Employee.apply(this,args);     //first way : Apply is used to inherit attribute defined in Employee function (class);
                                    //It will not inherit attache function via prototype.

    // Employee.apply(this,[args[0],args[1],args[2]]); //second way
   // Employee.apply(this,[name,salary,online]); // if we are using second way to create function.
    
}

SuperAdmin.prototype=Object.create(Employee.prototype);// we are creating prototype object for SuperAdmin and assigining Empoyee prototype to them.
// so we will be able to call attahced methods to Employee.
console.log(SuperAdmin.prototype);

// attaching a function to SuperAdmin() specifically
SuperAdmin.prototype.AdminSpecificFunction=function(){
    console.log('********propertirs of Super Admin object are as follows*************');
    console.log('name=',this.name,'salary=',this.salary,'online=',this.online);
    console.log('********************************************************************');
}


var sAdmin=new SuperAdmin('niranjan proto',6000,true);
sAdmin.logIn();
sAdmin.AdminSpecificFunction();

console.log(sAdmin);


sAdmin.LogOut();
