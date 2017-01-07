'use strict';

function solve(args) {
      let x = +args[0],
          y = +args[1],
          a = Math.pow((x-1), 2),
          b = Math.pow((y-1), 2),
          c = (a+b),
          InCircle = (Math.sqrt(c) <= 1.5);
          InRectangle = ((x <= 5) && (x >= -1)) && ((y <= 1) && (y >= -1));
          let IsInCircle = (InCircle ? "inside circle" : "outside circle");
          let IsInRectangle = (InRectangle ? "inside rectangle" : "outside rectangle" );
          console.log(IsInCircle , IsInRectangle);    
        }