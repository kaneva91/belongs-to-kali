'use strict';

function solve(args) {
    let arr1 = args[0],
        arr2 = args[1],
        shortLen = Math.min(arr1.length, arr2.length);
    if(arr1.length === arr2.length)
    {
       if (arr1 > arr2){
           console.log('>');
       }
       else if(arr1 < arr2){
           console.log('<');
       }
       else{
           console.log('=');
       }
    }
    else{
        for(let i = 0; i < shortLen; i +=1){
            if (arr1[i] > arr2[i]){
                console.log('>');
                break;
            }
            else{
                console.log('<');
                break;
            }
        }
    }
}


// function solve(args) {
//     let arr1 = args[0],
//         arr2 = args[1],
//         result = str1.localeCompare(str2);
//     if(result === -1){
//         console.log('<');
//     }
//     else if( result === 1){
//          console.log('>');
//     }
//     else{
//         console.log('=');
//     }
// }

