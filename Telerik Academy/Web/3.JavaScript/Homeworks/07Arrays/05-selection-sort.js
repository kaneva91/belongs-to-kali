'use strict';

function solve(args) {
   var len = +args[0];
    var   min;
 
  var min = +args[1], minIndex = 0; el = 0;
           
            //selection sort without helper array
            for (var numEl = 1; numEl < args.length-1; numEl++)
            {
                min = +args[numEl];
                minIndex = numEl;
                for (var i = numEl+1; i < args.length; i++)
                {
                    if (+args[i] < min)
                    {
                        min = +args[i];
                        minIndex = i;
                    }
                }
               
                //swap
                el = args[numEl];
                args[numEl] = min;
                args[minIndex] = el;
            }
 
             for(var i = 1 ; i <= len; i += 1){
        console.log(args[i]);
       
    }
}