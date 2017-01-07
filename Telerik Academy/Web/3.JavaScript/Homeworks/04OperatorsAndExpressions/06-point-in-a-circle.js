'use strict';

function isInCircle(arr){
    let distance = Math.sqrt(Math.pow(arr[0], 2) + Math.pow(arr[1], 2));
    if (distance <= 2){
        console.log('yes ' + distance.toFixed(2));  
    }
    else{
        console.log('no ' + distance.toFixed(2));  
    }
}