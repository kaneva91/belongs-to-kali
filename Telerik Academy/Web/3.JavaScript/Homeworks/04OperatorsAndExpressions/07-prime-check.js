'use strict';

function isPrime(arr){
    let num = arr[0],
        result = true;
    if (num < 0 || num === 1){
        result = false;
    }
    else{
        for(let i = 2; i <= Math.sqrt(num); i+= 1){
            if(num % i === 0){
                result = false;
                break;
            }
        }
    }
    console.log(result);  
}