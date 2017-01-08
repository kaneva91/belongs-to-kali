'use strict';

function solve(args){
  var n = args[0];
 for (var i = 1; i <= n; i++) {
      var result = "";
      for (var j = 1; j <= n; j++) {
        result += (i + j - 1);
        result += " ";
      }
      console.log(result);
    }
}