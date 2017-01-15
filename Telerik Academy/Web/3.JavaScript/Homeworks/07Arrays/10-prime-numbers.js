function solve(args) {
    var N = parseInt(args[0]);

    for (var i = N; i > 1; i -= 1) {
        var is_prime = true;
        for (var j = 2; j < i; j +=1) {
            if (i%j === 0) {
                is_prime = false;
                break;
            }
        }
        if (is_prime) {
            return i;
        }
    }
}