'use strict';

function CalcAreaAndPerimeter(args){
    let area = args[0] * args[1],
        perimeter = 2 *args[0] + 2 * args[1];
    console.log(area.toFixed(2) + " " + perimeter.toFixed(2));
}