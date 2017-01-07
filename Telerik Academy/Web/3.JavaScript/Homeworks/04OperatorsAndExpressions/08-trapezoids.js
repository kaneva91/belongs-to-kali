'use strict';

function trepezoids(arr){
    let a = +(arr[0]),
        b = +(arr[1]),
        h = +(arr[2]),
        area = ((a + b) * h) / 2;
    console.log(area.toFixed(7));
}
