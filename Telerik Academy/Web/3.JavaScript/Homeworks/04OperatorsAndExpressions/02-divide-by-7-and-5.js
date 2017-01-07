'use strict';

function divideBy7and5(num){
    if(num % 7 === 0 && num % 5 === 0){
        console.log('true ' + num);
    }
    else{
        console.log('false '+ num);
    }
}