'use strict';

function solve(arr){
    let n = +arr[0],
        result = '1 ';
    for(let i = 2; i <= n; i+= 1){
        result = result + (i + ' ');
    }
    return result;
}