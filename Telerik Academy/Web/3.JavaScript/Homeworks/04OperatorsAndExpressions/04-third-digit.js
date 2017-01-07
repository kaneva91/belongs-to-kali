'use strict';

function isThirdDigit7(num){
    let thirdDigit = ((num/ 100) % 10) | 0;
    if(thirdDigit === 7){
        console.log('true');
    }
    else{
        console.log('false ' + thirdDigit);
    }
}