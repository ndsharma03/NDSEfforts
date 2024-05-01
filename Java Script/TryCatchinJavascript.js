name="niranjan";
console.log(name);

fruittype="Oranges";
switch (fruittype) {
    case 'Oranges':
      console.log('Oranges are $0.59 a pound.');
      break;
    case 'Apples':
      console.log('Apples are $0.32 a pound.');
      //break;
    case 'Bananas':
      console.log('Bananas are $0.48 a pound.');
     // break;
    case 'Cherries':
      console.log('Cherries are $3.00 a pound.');
    //  break;
    case 'Mangoes':
      console.log('Mangoes are $0.56 a pound.');
     // break;
    case 'Papayas':
      console.log('Mangoes and papayas are $2.79 a pound.');
    //  break;
    default:
     console.log('Sorry, we are out of ' + fruittype + '.');
  }

  //-------------Try Catch------------
try{
        let i=0;
        let j=5;
            
        if(i==0){
                throw new UserDefinedException("value of i is Zero");
        }
        console.log( j/i);
}
catch( ex){
    console.log(ex.ToString());
}
 function UserDefinedException(message){
      this.Message=message,
      this.type="UserdefinedException"

      UserDefinedException.prototype.ToString=function(){
          console.log("throwing exception");
        return(this.Message +"     "+this.type);
      }
  }