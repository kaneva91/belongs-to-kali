'use strict';

function solve(arr){
    let a = +arr[0],
        b = +arr[1];
    if(a > b){
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
    }
    console.log(a + ' ' + b)
}