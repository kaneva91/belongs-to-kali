'use strict';

function solve(args){
    let arr = args.map(Number),
        count = 0,
        bestCount = 0;
    for(let i = 0; i < arr.length - 1; i += 1){
        if(arr[i]   < arr[i + 1]){
            count += 1;
           
            if(count > bestCount){
                bestCount = count;
            }
        }
        else{
            count = 0;
        }
    }
    console.log(bestCount + 1);
}