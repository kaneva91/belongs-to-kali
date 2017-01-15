'use strict';

function solve(args){
    let count = 0,
        bestCount = 0,
        num = 0;
    for(let i = 0; i < args.length; i += 1){
        for(let j = 0; j < args.length; j += 1){
            if(+args[i] === +args[j]){
                count += 1;
                if(count > bestCount){
                    bestCount = count;
                    num = +args[i];
                }
            }
        }
        count = 0;  
    }
    console.log(num + ' (' + bestCount + ' times)');
}