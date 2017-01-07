'use strict';

function solve(arr){
    let a = +arr[0],
        b = +arr[1],
        c = +arr[2];
        temp = - Infinity;
    if(a > b){
        temp = a;
        a = b;
        b = temp;
    }
    if(b > c){
         temp = b;
        b = c;
        c = temp;
    }
    if(a > c){
        temp = a;
        a = c;
        c = temp;
    }
    console.log(c + ' ' + b + ' ' + a);
}