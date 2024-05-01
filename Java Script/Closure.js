function Increment(counter){
    var _cnt=counter;
   return function InnerIncrementer(){
        return _cnt++;
    }
}

var inct=Increment(10);
console.log(inct());
console.log(inct());
console.log(inct());
console.log(inct());