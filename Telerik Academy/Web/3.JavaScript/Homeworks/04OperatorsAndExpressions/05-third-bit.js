'use strict';

function trirdBit(num){
    let mask = 1 << 3;
    let thirdBit = (num & mask) >> 3;
    console.log(thirdBit);
}