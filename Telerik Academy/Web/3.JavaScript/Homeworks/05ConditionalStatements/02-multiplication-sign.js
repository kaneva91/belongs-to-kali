'use strict';

function solve(arr){
    let a = +arr[0],
        b = +arr[1],
        c = +arr[2];
    if  (a === 0 || b === 0 ||c === 0){
        return '0';
    }
    else if(a > 0){
            if(b > 0){
                if(c > 0){
                    return '+';
                }
                else{
                    return '-';
                }
            }
            else{
                if(c > 0){
                    return '-';
                }
                else{
                    return '+';
                }
            }
    }
    else{
        if(b > 0){
            if(c > 0){
                return '-';
            }
            else{
                return '+';
            }
        }
        else{
           if(c > 0){
                return '+';
            }
            else{
                return '-';
            } 
        }
    }
}