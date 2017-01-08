'use struct';

function solve(args){
    let min = +args[0],
        max = +args[0],
        sum = parseFloat(args[0]),
        avg = 0;
    for(let i = 1; i <= args.length; i += 1){
       sum += parseFloat(args[i]);
        if(min > (+args[i])){
            min = (+args[i]);
        }
        if(max < (+args[i])){
            max = (+args[i]);
        }
    }
    avg = sum / args.length;
    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}