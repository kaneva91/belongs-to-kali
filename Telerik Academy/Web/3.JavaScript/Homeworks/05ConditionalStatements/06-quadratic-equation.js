'use strict';

function solve(args) {
  let a = +args[0],
  b = +args[1],
  c = +args[2],

  disc = Math.pow(b, 2) - (4 * a * c);

  if (disc < 0) {
    console.log('no real roots');
  }

  else if (disc === 0) {
    let x = -b / (2 * a);
    console.log('x1=x2=' + x.toFixed(2));
  }

  else if (disc > 0) {
    let sqrt = Math.sqrt(disc);

    let x1 = (-b + sqrt) / (2 * a);
    let x2 = (-b - sqrt) / (2 * a);

    if (x2 < x1) {
      let temp = x1;
      x1 = x2;
      x2 = temp;
    }

    console.log('x1=' + x1.toFixed(2) + "; x2=" + x2.toFixed(2));
  }
}