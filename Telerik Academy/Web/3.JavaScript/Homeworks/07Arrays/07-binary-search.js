'use strict';

function solve(args){
    let min = 0,
    max = +args[0] - 1,
    middle = 0,
    x = +args[args.length - 1];
    args.pop();

while(args[middle] != x && min <= max){
    middle =  Math.floor((min + max) / 2);

    if (args[middle] < x){
    min = middle + 1;
    }
    else{
        max = middle - 1;
    }
}

if (args[middle] != x){
    console.log(-1);
}
else{
    console.log(middle - 1);
}

}