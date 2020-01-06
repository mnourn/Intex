function factorial() {
}
factorial.prototype = {
    multiply: function (source, num) {
        var result = [];
        for (var i = 0; i < source.length; i++) {
            result.push(0);
        }
        var index = 0;
        var zero = true;
        while (num > 0) {
            var number = Math.floor(num % 10);
            if (number > 0) {
                zero = false;
                var reminder = 0;
                for (var i = 0; i < source.length; i++) {
                    var mult = source[i] * number + reminder;
                    if (i + index == result.length) {
                        result.push(0);
                    }
                    var tmp = result[i + index] + mult;
                    result[i + index] = Math.floor(tmp % 10);
                    reminder = Math.floor(tmp / 10);
                }
                while (reminder > 0) {
                    result.push(Math.floor(reminder % 10));
                    reminder = Math.floor(reminder / 10);
                }
            } else {
                if (zero) {
                    result.splice(0, 0, 0);
                }
            }
            num = Math.floor(num / 10);
            index++;
        }
        return result;
    },
    getFactorial: function (value) {
        var result = [];
        result.push(1);
        for (var i = 2; i <= value; i++) {
            result = this.multiply(result, i);
        }
        return result;
    }
}