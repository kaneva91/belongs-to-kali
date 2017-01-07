'use strict';

function solve(arr){
    let a = +arr[0],
        b = +arr[1],
        c = +arr[2],
        greater = -Infinity;
    if (a => b){
         greater = a;
    }
    else{
        greater = b;
    }
    if (greater <= c){
        greater = c;
    }
    return greater;
}