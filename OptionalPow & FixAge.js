function fixage(input){
    let result=input.filter(age=>age>18&&age<60).join(",");
    if(!result)
        return "NA";
    else return result
}


function optionalPow(a,b){
    const answer = confirm("Podnieść pierwszą liczbę do drugiej?");
    if (answer)
        return Math.pow(a,b);
    return Math.pow(b,a);
}