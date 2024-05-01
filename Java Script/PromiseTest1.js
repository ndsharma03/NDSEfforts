/// 3 ways to create object in Js:
// object literal
var obj1={
    name:"niranjan",
    Surname:"Sharma",
    fullName:function(){
        return this.name+"*******"+this.Surname;
    }
}


//console.log(obj1.__proto__)
obj1.__proto__.Reverse=function(){
    console.log(this.name+" "+this.Surname);
}
obj1.Reverse()
//factory function
var obj2= function(name,surname){

    return{
        name:name,
        surname:surname,
        fullname:function(){
           return this.name+"--"+this.surname;
        } 

    }

}

//Constructor function

var onew=function(nn,surname,age){
   let name=nn;
    this.surname=surname;
    this.age=age;
    this.PrintFullDetail=function(){
        return name+"--"+this.surname+"--"+this.age;
    }
}



var o2= obj2('nds','sha'),o3=obj2('vasu','sharma');

var o4=new onew('ooooooooo','dev',33);

console.log(o4.PrintFullDetail());
//o2.fullname();
console.log(o3.fullname());
//console.log(obj1.fullName())

class Abc{
    
    constructor(name,surname){
        this.name=name,
        this.surname=surname
    };
     print=function(){
            console.log(this.name+"=="+this.surname)
    }
}

let o5=new Abc('prallavi','sharma');
o5.print();

