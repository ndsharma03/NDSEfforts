
function Mobile(model ,price,qty){
 this.model=model;
 this.price=price;
 this.qty=qty;
}
var momsBonusAmount=300;

var phonePromise=new Promise(function(resolved,rejected)
{    
    if(momsBonusAmount >10000){
        // a new mobile purchased by mom
        var newMobile=new Mobile('Samsung Galaxy',10000,1);
        resolved(newMobile);
    } 
    else{
        rejected(null);
    }

});
phonePromise.then(function(mobile){ // resolved
    console.log("My mom buy  "+ mobile.qty +" mobile for me of "
                    + mobile.model +" whose price is "+mobile.price );
})
.catch(function(mobilenull) //rejected
{
    if(mobilenull==null)
    console.log("mom could not buy a mobile for me")})
.finally(function(){console.log("I am happy!!")});// executes in both cases


