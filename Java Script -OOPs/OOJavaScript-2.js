class Employee{

    /*constructor( firstname ,lastname,salary){
        this.firstname=firstname,
        this.lastname=lastname,
        this.salary=salary
    }*/
        

    Initializer(firstname,lastname,salary){
        this.firstname=firstname,
        this.lastname=lastname,
        this.salary=salary
    }

    GetFullName(){
        return this.firstname+" "+this.lastname;
    }
}
/*
var e1=new Employee('niranjan','sharma',3000);
var e2=new Employee('pranamya','sharma',3000);


console.log (e1);
console.log(e2);
console.log (e1.salary);
console.log(e2.salary);
console.log(e1.GetFullName());
console.log(e1+e2);
console.log(e1==e2);
*/

//==================================Another example ===============

class Math{
    
    Add(first,second){
        let a=parseInt(first);
        let b=parseInt(second);
        return a+b;
    }

    Sub(first,second){
        let a=parseInt(first);
        let b=parseInt(second);
        return (a-b);
    }

    MethodChaining(){
        return this;
    }
}

//Math class testing
console.log(new Math().Add(9,10));

var math1=new Math();
console.log(math1.Add("4","5"));
//math1=undefined;
//console.log(math1.Add("4","5")); unable to call add method as math1 is 'undefined' it's also true for null.
var a='54.3';
var b='34.3';
console.log(a+b);
console.log(parseFloat(a) +parseFloat(b));
[k,l,...m]=[5,6,4,4,4];
console.log("k="+k);
console.log("l="+l);
console.log(m);
var names=['niranjan','sharma','pranamya'];
console.log(names[0],names[2],names[1]);

console.log(new Math().MethodChaining().Add(3,9));